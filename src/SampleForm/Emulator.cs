using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Open3270;

namespace SampleForm
{
    public class OpenEmulator : RichTextBox
    {
        public TNEmulator TN3270 = new TNEmulator();
        private bool IsRedrawing = false;
        public void Connect(string Server, int Port, string Type, bool UseSsl)
        {
            TN3270.Debug = true;
            TN3270.Config.UseSSL = UseSsl;
            TN3270.Config.TermType = Type;
            TN3270.Connect(Server, Port, string.Empty);

            Redraw();
        }
        public void Redraw()
        {
            
        
            RichTextBox Render = new RichTextBox();
            StringBuilder sb = new StringBuilder();
            if (TN3270.IsConnected) {
                TN3270.Refresh(true, 1000); 
            }
            
            
            for (int i = 0; i < TN3270.CurrentScreenXML.CY; i++)
            {
                sb.AppendLine(TN3270.CurrentScreenXML.GetRow(i));
            }
            Render.Text = sb.ToString();
            Font fnt = new System.Drawing.Font("Consolas", 15);
            Render.Font = new System.Drawing.Font(fnt, FontStyle.Regular);

            IsRedrawing = true;
            Render.SelectAll();

            if (TN3270.CurrentScreenXML.Fields == null)
            {
                Color clr = Color.Lime;
                Render.SelectionProtected = false;
                Render.SelectionColor = clr;
                Render.DeselectAll();

                for (int i = 0; i < Render.Text.Length; i++)
                {
                    Render.Select(i, 1);
                    if (Render.SelectedText != " " && Render.SelectedText != "\n")
                        Render.SelectionColor = Color.Lime;
                }
                return;
            }

            Render.SelectionProtected = true;
            foreach (Open3270.TN3270.XMLScreenField field in TN3270.CurrentScreenXML.Fields)
            {


                System.Windows.Forms.Application.DoEvents();
                Color clr = Color.Lime;
                if (field.Attributes.FieldType == "High" && field.Attributes.Protected)
                    clr = Color.White;
                else if (field.Attributes.FieldType == "High")
                    clr = Color.Red;
                else if (field.Attributes.Protected)
                    clr = Color.RoyalBlue;

                Render.Select(field.Location.position + field.Location.top, field.Location.length);
                Render.SelectionProtected = false;
                Render.SelectionColor = clr;
                if (clr == Color.White || clr == Color.RoyalBlue)
                    Render.SelectionProtected = true;
            }

            for (int i = 0; i < Render.Text.Length; i++)
            {
                Render.Select(i, 1);
                if (Render.SelectedText != " " && Render.SelectedText != "\n" && Render.SelectionColor == Color.Black)
                {
                    Render.SelectionProtected = false;
                    Render.SelectionColor = Color.Lime;
                }
            }

            Render.SelectionStart = (TN3270.CursorY) * 81 + TN3270.CursorX;
            


            Render.ScrollToCaret();
            this.Rtf = Render.Rtf;
            this.SelectionStart = Render.SelectionStart;
            int cursorstart = this.SelectionStart;
            Debug.WriteLine(cursorstart);
            this.Select(cursorstart, 1);
            Debug.WriteLine(TN3270.CursorX + ", " + TN3270.CursorY );

            IsRedrawing = false;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            if (e.KeyChar == '\r')
            {
                if (TN3270.SendKey(true, TnKey.Enter, 20000))
                {
                    Redraw();
                }
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '\b')
            {
                this.Text.Remove(this.SelectionStart--,1);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '\t')
                return;

            TN3270.SetText(e.KeyChar.ToString());
            base.OnKeyPress(e);
        }

        protected override void OnSelectionChanged(EventArgs e)
        {
            if (TN3270.IsConnected)
            {
                base.OnSelectionChanged(e);
                if (!IsRedrawing)
                {
                    int i = this.SelectionStart, x, y = 0;
                    while (i >= 81)
                    {
                        y++;
                        i -= 81;
                    }
                    x = i;

                    TN3270.SetCursor(x, y);
                }
                this.Select(this.SelectionStart, 1);
            }
        }


       public void RefreshText(char c)
        { 
                this.SelectedText = c.ToString();
                this.Select(this.SelectionStart, 1);  
        }

    }
}

#region License
/* 
 *
 * Open3270 - A C# implementation of the TN3270/TN3270E protocol
 *
 * Copyright (c) 2004-2020 Michael Warriner
 * Modifications (c) as per Git change history
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 * and associated documentation files (the "Software"), to deal in the Software without restriction,
 * including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
 * and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
 * subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or substantial 
 * portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT 
 * LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
 * IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
 * SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

#endregion

namespace Open3270.TN3270
{
	using System;
	using System.Collections;
	using System.Security;

	internal delegate bool ActionDelegate(params object[] args);

	internal class Actions
	{

		readonly XtActionRec[] actions = null;
		readonly Telnet telnet;
		readonly Hashtable actionLookup = [];
		ArrayList datacapture = null;
		ArrayList datastringcapture = null;

		internal Actions(Telnet tn)
		{

			telnet = tn;
			actions = [
					new XtActionRec( "printtext",   false,  new ActionDelegate(telnet.Print.PrintTextAction )),
					new XtActionRec( "flip",        false,  new ActionDelegate(telnet.Keyboard.FlipAction )),
					new XtActionRec( "ascii",       false,  new ActionDelegate(telnet.Controller.AsciiAction )),
					new XtActionRec( "dumpxml",     false,  new ActionDelegate(telnet.Controller.DumpXMLAction )),
					new XtActionRec( "asciifield",  false,  new ActionDelegate(telnet.Controller.AsciiFieldAction )),
					new XtActionRec( "attn",        true,   new ActionDelegate(telnet.Keyboard.AttnAction )),
					new XtActionRec( "backspace",   false,  new ActionDelegate(telnet.Keyboard.BackSpaceAction )),
					new XtActionRec( "backtab",     false,  new ActionDelegate(telnet.Keyboard.BackTab_action )),
					new XtActionRec( "circumnot",   false,  new ActionDelegate(telnet.Keyboard.CircumNotAction )),
					new XtActionRec( "clear",       true,   new ActionDelegate(telnet.Keyboard.ClearAction )),
					new XtActionRec( "cursorselect", false, new ActionDelegate(telnet.Keyboard.CursorSelectAction )),
					new XtActionRec( "delete",       false, new ActionDelegate(telnet.Keyboard.DeleteAction )),
					new XtActionRec( "deletefield",  false, new ActionDelegate(telnet.Keyboard.DeleteFieldAction )),
					new XtActionRec( "deleteword",   false, new ActionDelegate(telnet.Keyboard.DeleteWordAction )),
					new XtActionRec( "down",         false, new ActionDelegate(telnet.Keyboard.MoveCursorDown )),
					new XtActionRec( "dup",          false, new ActionDelegate(telnet.Keyboard.DupAction )),
					new XtActionRec("emulateinput",  true,  new ActionDelegate(telnet.Keyboard.EmulateInputAction )),
					new XtActionRec( "enter",        true,  new ActionDelegate(telnet.Keyboard.EnterAction )),
					new XtActionRec( "erase",        false, new ActionDelegate(telnet.Keyboard.EraseAction )),
					new XtActionRec( "eraseeof",     false, new ActionDelegate(telnet.Keyboard.EraseEndOfFieldAction )),
					new XtActionRec( "eraseinput",   false, new ActionDelegate(telnet.Keyboard.EraseInputAction )),
					new XtActionRec( "fieldend",    false,  new ActionDelegate(telnet.Keyboard.FieldEndAction )),
					new XtActionRec( "fields",      false,  new ActionDelegate(telnet.Keyboard.FieldsAction )),
					new XtActionRec( "fieldget",    false,  new ActionDelegate(telnet.Keyboard.FieldGetAction )),
					new XtActionRec( "fieldset",    false,  new ActionDelegate(telnet.Keyboard.FieldSetAction )),
					new XtActionRec( "fieldmark",   false,  new ActionDelegate(telnet.Keyboard.FieldMarkAction )),
					new XtActionRec( "fieldexit",   false,  new ActionDelegate(telnet.Keyboard.FieldExitAction )),
					new XtActionRec( "hexString",   false,  new ActionDelegate(telnet.Keyboard.HexStringAction)),
					new XtActionRec( "home",        false,  new ActionDelegate(telnet.Keyboard.HomeAction )),
					new XtActionRec( "insert",      false,  new ActionDelegate(telnet.Keyboard.InsertAction )),
					new XtActionRec( "interrupt",   true,   new ActionDelegate(telnet.Keyboard.InterruptAction )),
					new XtActionRec( "key",         false,  new ActionDelegate(telnet.Keyboard.SendKeyAction )),
					new XtActionRec( "left",        false,  new ActionDelegate(telnet.Keyboard.LeftAction )),
					new XtActionRec( "left2",       false,  new ActionDelegate(telnet.Keyboard.MoveCursorLeft2Positions )),
					new XtActionRec( "monocase",    false,  new ActionDelegate(telnet.Keyboard.MonoCaseAction )),
					new XtActionRec( "movecursor",  false,  new ActionDelegate(telnet.Keyboard.MoveCursorAction )),
					new XtActionRec( "Newline",     false,  new ActionDelegate(telnet.Keyboard.MoveCursorToNewLine )),
					new XtActionRec( "NextWord",    false,  new ActionDelegate(telnet.Keyboard.MoveCursorToNextUnprotectedWord )),
					new XtActionRec( "PA",          true,   new ActionDelegate(telnet.Keyboard.PAAction )),
					new XtActionRec( "PF",          true,   new ActionDelegate(telnet.Keyboard.PFAction )),
					new XtActionRec( "PreviousWord",false,  new ActionDelegate(telnet.Keyboard.PreviousWordAction )),
					new XtActionRec( "Reset",       true,  new ActionDelegate(telnet.Keyboard.ResetAction )),
					new XtActionRec( "Right",       false,  new ActionDelegate(telnet.Keyboard.MoveRight )),
					new XtActionRec( "Right2",      false,  new ActionDelegate(telnet.Keyboard.MoveCursorRight2Positions )),
					new XtActionRec( "String",      true,   new ActionDelegate(telnet.Keyboard.SendStringAction )),
					new XtActionRec( "SysReq",      true,   new ActionDelegate(telnet.Keyboard.SystemRequestAction )),
					new XtActionRec( "Tab",         false,  new ActionDelegate(telnet.Keyboard.TabForwardAction )),
					new XtActionRec( "ToggleInsert", false, new ActionDelegate(telnet.Keyboard.ToggleInsertAction )),
					new XtActionRec( "ToggleReverse",false, new ActionDelegate(telnet.Keyboard.ToggleReverseAction )),
					new XtActionRec( "Up",          false,  new ActionDelegate(telnet.Keyboard.MoveCursorUp )),
				];
		}

		public readonly string[] ia_name = ["String", "Paste", "Screen redraw", "Keypad", "Default", "Key",
							"Macro", "Script", "Peek", "Typeahead", "File transfer", "Command", "Keymap"];


		public static bool Action_internal(ActionDelegate action, params object[] args) => action(args);

		public void Action_output(string data) => Action_output(data, false);

		private static string EncodeXML(string data) => SecurityElement.Escape(data);

		public void Action_output(string data, bool encode)
		{
			datacapture ??= [];
			datastringcapture ??= [];

			datacapture.Add(System.Text.Encoding.ASCII.GetBytes(data));

			if (encode)
			{
				data = EncodeXML(data);
			}

			datastringcapture.Add(data);
		}

		public void Action_output(byte[] data, int length) => Action_output(data, length, false);

		public void Action_output(byte[] data, int length, bool encode)
		{
			datacapture ??= [];
			datastringcapture ??= [];

			byte[] temp = new byte[length];
			int i;
			for (i = 0; i < length; i++)
			{
				temp[i] = data[i];
			}
			datacapture.Add(temp);
			string strdata = System.Text.Encoding.ASCII.GetString(temp);
			if (encode)
			{
				strdata = EncodeXML(strdata);
			}

			datastringcapture.Add(strdata);
		}

		public string GetStringData(int index)
		{
			if (datastringcapture == null)
				return null;
			if (index >= 0 && index < datastringcapture.Count)
				return (string)datastringcapture[index];
			else
				return null;
		}

		public bool KeyboardCommandCausesSubmit(string name)
		{
			if (actionLookup[name.ToLower()] is XtActionRec rec)
			{
				return rec.CausesSubmit;
			}

			for (int i = 0; i < actions.Length; i++)
			{
				if (actions[i].name.ToLower() == name.ToLower())
				{
					actionLookup[name.ToLower()] = actions[i];
					return actions[i].CausesSubmit;
				}
			}

			throw new ApplicationException("Sorry, action '" + name + "' is not known");
		}

		public bool Execute(string name, params object[] args)
		{
			telnet.Events.Clear();
			// Check that we're connected
			if (!telnet.IsConnected)
			{
				throw new Open3270.TNHostException("TN3270 Host is not connected", telnet.DisconnectReason, null);
			}

			datacapture = null;
			datastringcapture = null;
			if (actionLookup[name.ToLower()] is XtActionRec rec)
			{
				return rec.proc(args);
			}

			for (int i = 0; i < actions.Length; i++)
			{
				if (actions[i].name.ToLower() == name.ToLower())
				{
					actionLookup[name.ToLower()] = actions[i];
					return actions[i].proc(args);
				}
			}

			throw new ApplicationException("Sorry, action '" + name + "' is not known");
		}

		internal class XtActionRec(string name, bool CausesSubmit, ActionDelegate fn)
		{
			public ActionDelegate proc = fn;
			public string name = name.ToLower();
			public bool CausesSubmit = CausesSubmit;
		}
	}
}

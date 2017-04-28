/*
                    GNU LESSER GENERAL PUBLIC LICENSE
                       Version 3, 29 June 2007

 Copyright (C) 2007 Free Software Foundation, Inc. <http://fsf.org/>
 Everyone is permitted to copy and distribute verbatim copies
 of this license document, but changing it is not allowed.


  This version of the GNU Lesser General Public License incorporates
the terms and conditions of version 3 of the GNU General Public
License, supplemented by the additional permissions listed below.

  0. Additional Definitions.

  As used herein, "this License" refers to version 3 of the GNU Lesser
General Public License, and the "GNU GPL" refers to version 3 of the GNU
General Public License.

  "The Library" refers to a covered work governed by this License,
other than an Application or a Combined Work as defined below.

  An "Application" is any work that makes use of an interface provided
by the Library, but which is not otherwise based on the Library.
Defining a subclass of a class defined by the Library is deemed a mode
of using an interface provided by the Library.

  A "Combined Work" is a work produced by combining or linking an
Application with the Library.  The particular version of the Library
with which the Combined Work was made is also called the "Linked
Version".

  The "Minimal Corresponding Source" for a Combined Work means the
Corresponding Source for the Combined Work, excluding any source code
for portions of the Combined Work that, considered in isolation, are
based on the Application, and not on the Linked Version.

  The "Corresponding Application Code" for a Combined Work means the
object code and/or source code for the Application, including any data
and utility programs needed for reproducing the Combined Work from the
Application, but excluding the System Libraries of the Combined Work.

  1. Exception to Section 3 of the GNU GPL.

  You may convey a covered work under sections 3 and 4 of this License
without being bound by section 3 of the GNU GPL.

  2. Conveying Modified Versions.

  If you modify a copy of the Library, and, in your modifications, a
facility refers to a function or data to be supplied by an Application
that uses the facility (other than as an argument passed when the
facility is invoked), then you may convey a copy of the modified
version:

   a) under this License, provided that you make a good faith effort to
   ensure that, in the event an Application does not supply the
   function or data, the facility still operates, and performs
   whatever part of its purpose remains meaningful, or

   b) under the GNU GPL, with none of the additional permissions of
   this License applicable to that copy.

  3. Object Code Incorporating Material from Library Header Files.

  The object code form of an Application may incorporate material from
a header file that is part of the Library.  You may convey such object
code under terms of your choice, provided that, if the incorporated
material is not limited to numerical parameters, data structure
layouts and accessors, or small macros, inline functions and templates
(ten or fewer lines in length), you do both of the following:

   a) Give prominent notice with each copy of the object code that the
   Library is used in it and that the Library and its use are
   covered by this License.

   b) Accompany the object code with a copy of the GNU GPL and this license
   document.

  4. Combined Works.

  You may convey a Combined Work under terms of your choice that,
taken together, effectively do not restrict modification of the
portions of the Library contained in the Combined Work and reverse
engineering for debugging such modifications, if you also do each of
the following:

   a) Give prominent notice with each copy of the Combined Work that
   the Library is used in it and that the Library and its use are
   covered by this License.

   b) Accompany the Combined Work with a copy of the GNU GPL and this license
   document.

   c) For a Combined Work that displays copyright notices during
   execution, include the copyright notice for the Library among
   these notices, as well as a reference directing the user to the
   copies of the GNU GPL and this license document.

   d) Do one of the following:

       0) Convey the Minimal Corresponding Source under the terms of this
       License, and the Corresponding Application Code in a form
       suitable for, and under terms that permit, the user to
       recombine or relink the Application with a modified version of
       the Linked Version to produce a modified Combined Work, in the
       manner specified by section 6 of the GNU GPL for conveying
       Corresponding Source.

       1) Use a suitable shared library mechanism for linking with the
       Library.  A suitable mechanism is one that (a) uses at run time
       a copy of the Library already present on the user's computer
       system, and (b) will operate properly with a modified version
       of the Library that is interface-compatible with the Linked
       Version.

   e) Provide Installation Information, but only if you would otherwise
   be required to provide such information under section 6 of the
   GNU GPL, and only to the extent that such information is
   necessary to install and execute a modified version of the
   Combined Work produced by recombining or relinking the
   Application with a modified version of the Linked Version. (If
   you use option 4d0, the Installation Information must accompany
   the Minimal Corresponding Source and Corresponding Application
   Code. If you use option 4d1, you must provide the Installation
   Information in the manner specified by section 6 of the GNU GPL
   for conveying Corresponding Source.)

  5. Combined Libraries.

  You may place library facilities that are a work based on the
Library side by side in a single library together with other library
facilities that are not Applications and are not covered by this
License, and convey such a combined library under terms of your
choice, if you do both of the following:

   a) Accompany the combined library with a copy of the same work based
   on the Library, uncombined with any other library facilities,
   conveyed under the terms of this License.

   b) Give prominent notice with the combined library that part of it
   is a work based on the Library, and explaining where to find the
   accompanying uncombined form of the same work.

  6. Revised Versions of the GNU Lesser General Public License.

  The Free Software Foundation may publish revised and/or new versions
of the GNU Lesser General Public License from time to time. Such new
versions will be similar in spirit to the present version, but may
differ in detail to address new problems or concerns.

  Each version is given a distinguishing version number. If the
Library as you received it specifies that a certain numbered version
of the GNU Lesser General Public License "or any later version"
applies to it, you have the option of following the terms and
conditions either of that published version or of any later version
published by the Free Software Foundation. If the Library as you
received it does not specify a version number of the GNU Lesser
General Public License, you may choose any version of the GNU Lesser
General Public License ever published by the Free Software Foundation.

  If the Library as you received it specifies that a proxy can decide
whether future versions of the GNU Lesser General Public License shall
apply, that proxy's public statement of acceptance of any version is
permanent authorization for you to choose that version for the
Library.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NeoSystems.WinFormsUtils
{
    /// <summary>
    /// webutils extension methods class
    /// </summary>
    public static class WebBrowserExtensions
    {
        /// <summary>
        /// Extension method to wait until a page is fully downloaded.
        /// Will fully block any further execution on thread unitl page complete
        /// </summary>
        /// <param name="wb">webbrowser ref</param>
        public static void WaitForDownload(this WebBrowser wb)
        {
            while (wb.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }

        /// <summary>
        /// Wait for a certain time to expire while the browser does its thing
        /// This routine will wait in chunks of 100 ms
        /// </summary>
        /// <param name="wb">webbrowser ref</param>
        /// <param name="time_in_ms">time in ms to wait</param>
        public static void WaitTime(this WebBrowser wb, int time_in_ms)
        {
            int cnt = (time_in_ms / 100) + 1;

            for (int i = 0; i < cnt; i++)
            {
                Thread.Sleep(100);
                Application.DoEvents();
            }
        }

        // DoWebLogin is based on the following original VB code:
        //
        // Public Class Form1   
        //    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
        //        'Part 1: Load Yahoo login page in Form_Load event  
        //        WebBrowser1.Navigate("https://login.yahoo.com/")  
        //    End Sub 

        //    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted  
        //        'Part 2: Locate the Username TextBox and automatically input your username  
        //        '<INPUT class=yreg_ipt id=username maxLength=96 size=17 name=login>  
        //        Dim theElementCollection As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("Input")  
        //        For Each curElement As HtmlElement In theElementCollection  
        //            Dim controlName As String = curElement.GetAttribute("id").ToString  
        //            If controlName = "username" Then 
        //                curElement.SetAttribute("Value", "your username")  
        //            End If 
        //        Next 

        //        'Part 3: Locate the Password TextBox and automatically input your password  
        //        '<INPUT class=yreg_ipt id=passwd type=password maxLength=64 size=17 value="" name=passwd>  
        //        theElementCollection = WebBrowser1.Document.GetElementsByTagName("Input")  
        //        For Each curElement As HtmlElement In theElementCollection  
        //            Dim controlName As String = curElement.GetAttribute("id").ToString  
        //            If controlName = "passwd" Then 
        //                curElement.SetAttribute("Value", "your password")  
        //            End If 
        //        Next 

        //        'Part 4: Locate the "Sign In" Button and automatically click it  
        //        '<INPUT type=submit value="Sign In" name=.save>  
        //        theElementCollection = WebBrowser1.Document.GetElementsByTagName("Input")  
        //        For Each curElement As HtmlElement In theElementCollection  
        //            If curElement.GetAttribute("value").Equals("Sign In") Then 
        //                curElement.InvokeMember("click")  
        //                'Javascript has a click method for we need to invoke on the current submit button element.  
        //            End If 
        //        Next 
        //    End Sub 

        //End Class 

        /// <summary>
        /// Do a login in a webbrowser  
        /// </summary>
        /// <param name="browser">browser instance</param>
        /// <param name="usernametag">id of the username input to look for</param>
        /// <param name="passwordtag">id of the password input tag to look for</param>
        /// <param name="username">username to use to log in</param>
        /// <param name="password">password to log in with</param>
        /// <param name="clickstrvalue">click string to look for</param>
        public static void DoWebLogin(this WebBrowser browser, string usernametag, string passwordtag, string username, string password, string clickstrvalue)
        {
            browser.Document.SetHtmlDocAttr("input", usernametag, "id", "Value", username);
            browser.Document.SetHtmlDocAttr("input", passwordtag, "id", "Value", password);
            browser.Document.ClickHtmlButton("input", "value", clickstrvalue);

        }

        /// <summary>
        /// <para>
        /// Extension method to HtmlDocument: set an attribute value of an element in an HTML document.
        /// </para>
        /// 
        /// <para>
        /// For example to set the attribute "Value" to "myusername" in the following tag:
        /// </para>
        /// <para>
        /// <code>&lt;INPUT class=yreg_ipt id=username maxLength=96 size=17 name=login &gt;</code>        
        /// </para>
        /// <para>
        /// usage: htmldoc.SetHtmlDocAttr("input","username","id","Value","myusername")
        /// </para>
        /// 
        /// </summary>
        /// <param name="htmldoc">Ref to the HtmlDocument instance</param>
        /// <param name="tagnametosearch">What element to serach, eg "input"</param>
        /// <param name="controlnametosearch">name of the control, eg "username"</param>
        /// <param name="attrtosearch">What attribute value to search, eg "id"</param>
        /// <param name="attrtoset">Attribute to set, eg "Value"</param>
        /// <param name="valtoset">Value to set the attribute the value to, eg "myusername"</param>
        public static void SetHtmlDocAttr(this HtmlDocument htmldoc, string tagnametosearch, string controlnametosearch, string attrtosearch, string attrtoset, string valtoset)
        {
            HtmlElementCollection elementCollection = htmldoc.GetElementsByTagName(tagnametosearch);
            foreach (HtmlElement e in elementCollection)
            {
                string controlname = e.GetAttribute(attrtosearch).ToString();
                if (controlname == controlnametosearch)
                {
                    e.SetAttribute(attrtoset, valtoset);
                }
            }
        }

        /// <summary>
        /// <para>
        /// Extension method to click an html button in a document
        /// </para>
        /// <para>
        /// To click the button from the following Html tag:
        /// </para>
        /// <para>
        /// <code>&lt; INPUT type=submit value="Sign In" name=.save &gt;</code>
        /// </para>
        /// <para>
        /// Use as follow:
        /// htmldoc.ClickHtmlButton("input", "value", "Sign In")
        /// </para>
        /// </summary>
        /// <param name="htmldoc">Ref to HtmlDocument class</param>
        /// <param name="tagnametosearch">Tag type to searhc, eg "input"</param>
        /// <param name="attrtosearch">Property type to search, eg "value"</param>
        /// <param name="valuetosearch">Value of the property to expect, eg "Sign in"</param>
        public static void ClickHtmlButton(this HtmlDocument htmldoc, string tagnametosearch, string attrtosearch, string valuetosearch)
        {
            HtmlElementCollection elementCollection = htmldoc.GetElementsByTagName("Input");
            foreach (HtmlElement e in elementCollection)
            {
                if (e.GetAttribute(attrtosearch).Equals(valuetosearch))
                {
                    // Javascript has a click method for we need to invoke on the current submit button element.  
                    e.InvokeMember("click");
                }
            }
        }

    }

}

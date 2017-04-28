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
using System.ComponentModel;
using System.Windows;

namespace NeoSystems.WinFormsUtils
{
	partial class AboutBox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.DetailsButton = new System.Windows.Forms.Button();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.AppDateLabel = new System.Windows.Forms.Label();
            this.SysInfoButton = new System.Windows.Forms.Button();
            this.AppCopyrightLabel = new System.Windows.Forms.Label();
            this.AppVersionLabel = new System.Windows.Forms.Label();
            this.AppDescriptionLabel = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.AppTitleLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.MoreRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TabPanelDetails = new System.Windows.Forms.TabControl();
            this.TabPageApplication = new System.Windows.Forms.TabPage();
            this.AppInfoListView = new System.Windows.Forms.ListView();
            this.colKey = new System.Windows.Forms.ColumnHeader();
            this.colValue = new System.Windows.Forms.ColumnHeader();
            this.TabPageAssemblies = new System.Windows.Forms.TabPage();
            this.AssemblyInfoListView = new System.Windows.Forms.ListView();
            this.colAssemblyName = new System.Windows.Forms.ColumnHeader();
            this.colAssemblyVersion = new System.Windows.Forms.ColumnHeader();
            this.colAssemblyBuilt = new System.Windows.Forms.ColumnHeader();
            this.colAssemblyCodeBase = new System.Windows.Forms.ColumnHeader();
            this.TabPageAssemblyDetails = new System.Windows.Forms.TabPage();
            this.AssemblyDetailsListView = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.AssemblyNamesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.TabPanelDetails.SuspendLayout();
            this.TabPageApplication.SuspendLayout();
            this.TabPageAssemblies.SuspendLayout();
            this.TabPageAssemblyDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetailsButton
            // 
            this.DetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsButton.Location = new System.Drawing.Point(228, 245);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(76, 23);
            this.DetailsButton.TabIndex = 25;
            this.DetailsButton.Text = "&Details >>";
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(14, 7);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(32, 32);
            this.ImagePictureBox.TabIndex = 24;
            this.ImagePictureBox.TabStop = false;
            // 
            // AppDateLabel
            // 
            this.AppDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AppDateLabel.Location = new System.Drawing.Point(6, 79);
            this.AppDateLabel.Name = "AppDateLabel";
            this.AppDateLabel.Size = new System.Drawing.Size(380, 16);
            this.AppDateLabel.TabIndex = 23;
            this.AppDateLabel.Text = "Built on %builddate%";
            // 
            // SysInfoButton
            // 
            this.SysInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SysInfoButton.Location = new System.Drawing.Point(212, 245);
            this.SysInfoButton.Name = "SysInfoButton";
            this.SysInfoButton.Size = new System.Drawing.Size(92, 23);
            this.SysInfoButton.TabIndex = 22;
            this.SysInfoButton.Text = "&System Info...";
            this.SysInfoButton.Visible = false;
            this.SysInfoButton.Click += new System.EventHandler(this.SysInfoButton_Click);
            // 
            // AppCopyrightLabel
            // 
            this.AppCopyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AppCopyrightLabel.Location = new System.Drawing.Point(6, 99);
            this.AppCopyrightLabel.Name = "AppCopyrightLabel";
            this.AppCopyrightLabel.Size = new System.Drawing.Size(380, 16);
            this.AppCopyrightLabel.TabIndex = 21;
            this.AppCopyrightLabel.Text = "Copyright © %year%, %company%";
            // 
            // AppVersionLabel
            // 
            this.AppVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AppVersionLabel.Location = new System.Drawing.Point(6, 59);
            this.AppVersionLabel.Name = "AppVersionLabel";
            this.AppVersionLabel.Size = new System.Drawing.Size(380, 16);
            this.AppVersionLabel.TabIndex = 20;
            this.AppVersionLabel.Text = "Version %version%";
            // 
            // AppDescriptionLabel
            // 
            this.AppDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AppDescriptionLabel.Location = new System.Drawing.Point(58, 27);
            this.AppDescriptionLabel.Name = "AppDescriptionLabel";
            this.AppDescriptionLabel.Size = new System.Drawing.Size(328, 16);
            this.AppDescriptionLabel.TabIndex = 19;
            this.AppDescriptionLabel.Text = "%description%";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Location = new System.Drawing.Point(6, 47);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(380, 2);
            this.GroupBox1.TabIndex = 18;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "GroupBox1";
            // 
            // AppTitleLabel
            // 
            this.AppTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AppTitleLabel.Location = new System.Drawing.Point(58, 7);
            this.AppTitleLabel.Name = "AppTitleLabel";
            this.AppTitleLabel.Size = new System.Drawing.Size(328, 16);
            this.AppTitleLabel.TabIndex = 17;
            this.AppTitleLabel.Text = "%title%";
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OKButton.Location = new System.Drawing.Point(312, 245);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(76, 23);
            this.OKButton.TabIndex = 16;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // MoreRichTextBox
            // 
            this.MoreRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MoreRichTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MoreRichTextBox.Location = new System.Drawing.Point(6, 123);
            this.MoreRichTextBox.Name = "MoreRichTextBox";
            this.MoreRichTextBox.ReadOnly = true;
            this.MoreRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MoreRichTextBox.Size = new System.Drawing.Size(380, 114);
            this.MoreRichTextBox.TabIndex = 26;
            this.MoreRichTextBox.Text = "%product% is %copyright%, %trademark%";
            this.MoreRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.MoreRichTextBox_LinkClicked);
            // 
            // TabPanelDetails
            // 
            this.TabPanelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TabPanelDetails.Controls.Add(this.TabPageApplication);
            this.TabPanelDetails.Controls.Add(this.TabPageAssemblies);
            this.TabPanelDetails.Controls.Add(this.TabPageAssemblyDetails);
            this.TabPanelDetails.Location = new System.Drawing.Point(6, 123);
            this.TabPanelDetails.Name = "TabPanelDetails";
            this.TabPanelDetails.SelectedIndex = 0;
            this.TabPanelDetails.Size = new System.Drawing.Size(378, 114);
            this.TabPanelDetails.TabIndex = 27;
            this.TabPanelDetails.Visible = false;
            this.TabPanelDetails.SelectedIndexChanged += new System.EventHandler(this.TabPanelDetails_SelectedIndexChanged);
            // 
            // TabPageApplication
            // 
            this.TabPageApplication.Controls.Add(this.AppInfoListView);
            this.TabPageApplication.Location = new System.Drawing.Point(4, 22);
            this.TabPageApplication.Name = "TabPageApplication";
            this.TabPageApplication.Size = new System.Drawing.Size(370, 88);
            this.TabPageApplication.TabIndex = 0;
            this.TabPageApplication.Text = "Application";
            // 
            // AppInfoListView
            // 
            this.AppInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colKey,
            this.colValue});
            this.AppInfoListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppInfoListView.FullRowSelect = true;
            this.AppInfoListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AppInfoListView.Location = new System.Drawing.Point(0, 0);
            this.AppInfoListView.Name = "AppInfoListView";
            this.AppInfoListView.Size = new System.Drawing.Size(370, 88);
            this.AppInfoListView.TabIndex = 16;
            this.AppInfoListView.UseCompatibleStateImageBehavior = false;
            this.AppInfoListView.View = System.Windows.Forms.View.Details;
            // 
            // colKey
            // 
            this.colKey.Text = "Application Key";
            this.colKey.Width = 120;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 700;
            // 
            // TabPageAssemblies
            // 
            this.TabPageAssemblies.Controls.Add(this.AssemblyInfoListView);
            this.TabPageAssemblies.Location = new System.Drawing.Point(4, 22);
            this.TabPageAssemblies.Name = "TabPageAssemblies";
            this.TabPageAssemblies.Size = new System.Drawing.Size(370, 88);
            this.TabPageAssemblies.TabIndex = 1;
            this.TabPageAssemblies.Text = "Assemblies";
            // 
            // AssemblyInfoListView
            // 
            this.AssemblyInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAssemblyName,
            this.colAssemblyVersion,
            this.colAssemblyBuilt,
            this.colAssemblyCodeBase});
            this.AssemblyInfoListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssemblyInfoListView.FullRowSelect = true;
            this.AssemblyInfoListView.Location = new System.Drawing.Point(0, 0);
            this.AssemblyInfoListView.MultiSelect = false;
            this.AssemblyInfoListView.Name = "AssemblyInfoListView";
            this.AssemblyInfoListView.Size = new System.Drawing.Size(370, 88);
            this.AssemblyInfoListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.AssemblyInfoListView.TabIndex = 13;
            this.AssemblyInfoListView.UseCompatibleStateImageBehavior = false;
            this.AssemblyInfoListView.View = System.Windows.Forms.View.Details;
            this.AssemblyInfoListView.DoubleClick += new System.EventHandler(this.AssemblyInfoListView_DoubleClick);
            this.AssemblyInfoListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.AssemblyInfoListView_ColumnClick);
            // 
            // colAssemblyName
            // 
            this.colAssemblyName.Text = "Assembly";
            this.colAssemblyName.Width = 123;
            // 
            // colAssemblyVersion
            // 
            this.colAssemblyVersion.Text = "Version";
            this.colAssemblyVersion.Width = 100;
            // 
            // colAssemblyBuilt
            // 
            this.colAssemblyBuilt.Text = "Built";
            this.colAssemblyBuilt.Width = 130;
            // 
            // colAssemblyCodeBase
            // 
            this.colAssemblyCodeBase.Text = "CodeBase";
            this.colAssemblyCodeBase.Width = 750;
            // 
            // TabPageAssemblyDetails
            // 
            this.TabPageAssemblyDetails.Controls.Add(this.AssemblyDetailsListView);
            this.TabPageAssemblyDetails.Controls.Add(this.AssemblyNamesComboBox);
            this.TabPageAssemblyDetails.Location = new System.Drawing.Point(4, 22);
            this.TabPageAssemblyDetails.Name = "TabPageAssemblyDetails";
            this.TabPageAssemblyDetails.Size = new System.Drawing.Size(370, 88);
            this.TabPageAssemblyDetails.TabIndex = 2;
            this.TabPageAssemblyDetails.Text = "Assembly Details";
            // 
            // AssemblyDetailsListView
            // 
            this.AssemblyDetailsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.AssemblyDetailsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssemblyDetailsListView.FullRowSelect = true;
            this.AssemblyDetailsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AssemblyDetailsListView.Location = new System.Drawing.Point(0, 21);
            this.AssemblyDetailsListView.Name = "AssemblyDetailsListView";
            this.AssemblyDetailsListView.Size = new System.Drawing.Size(370, 67);
            this.AssemblyDetailsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.AssemblyDetailsListView.TabIndex = 19;
            this.AssemblyDetailsListView.UseCompatibleStateImageBehavior = false;
            this.AssemblyDetailsListView.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Assembly Key";
            this.ColumnHeader1.Width = 120;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Value";
            this.ColumnHeader2.Width = 700;
            // 
            // AssemblyNamesComboBox
            // 
            this.AssemblyNamesComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AssemblyNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssemblyNamesComboBox.Location = new System.Drawing.Point(0, 0);
            this.AssemblyNamesComboBox.Name = "AssemblyNamesComboBox";
            this.AssemblyNamesComboBox.Size = new System.Drawing.Size(370, 21);
            this.AssemblyNamesComboBox.Sorted = true;
            this.AssemblyNamesComboBox.TabIndex = 18;
            this.AssemblyNamesComboBox.SelectedIndexChanged += new System.EventHandler(this.AssemblyNamesComboBox_SelectedIndexChanged);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.OKButton;
            this.ClientSize = new System.Drawing.Size(394, 275);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.AppDateLabel);
            this.Controls.Add(this.SysInfoButton);
            this.Controls.Add(this.AppCopyrightLabel);
            this.Controls.Add(this.AppVersionLabel);
            this.Controls.Add(this.AppDescriptionLabel);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.AppTitleLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.MoreRichTextBox);
            this.Controls.Add(this.TabPanelDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About %title%";
            this.Load += new System.EventHandler(this.AboutBox_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AboutBox_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.TabPanelDetails.ResumeLayout(false);
            this.TabPageApplication.ResumeLayout(false);
            this.TabPageAssemblies.ResumeLayout(false);
            this.TabPageAssemblyDetails.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button DetailsButton;
		private System.Windows.Forms.PictureBox ImagePictureBox;
		private System.Windows.Forms.Label AppDateLabel;
		private System.Windows.Forms.Button SysInfoButton;
		private System.Windows.Forms.Label AppCopyrightLabel;
		private System.Windows.Forms.Label AppVersionLabel;
		private System.Windows.Forms.Label AppDescriptionLabel;
		private System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.Label AppTitleLabel;
		private System.Windows.Forms.Button OKButton;
		internal System.Windows.Forms.RichTextBox MoreRichTextBox;
		internal System.Windows.Forms.TabControl TabPanelDetails;
		internal System.Windows.Forms.TabPage TabPageApplication;
		internal System.Windows.Forms.ListView AppInfoListView;
		internal System.Windows.Forms.ColumnHeader colKey;
		internal System.Windows.Forms.ColumnHeader colValue;
		internal System.Windows.Forms.TabPage TabPageAssemblies;
		internal System.Windows.Forms.ListView AssemblyInfoListView;
		internal System.Windows.Forms.ColumnHeader colAssemblyName;
		internal System.Windows.Forms.ColumnHeader colAssemblyVersion;
		internal System.Windows.Forms.ColumnHeader colAssemblyBuilt;
		internal System.Windows.Forms.ColumnHeader colAssemblyCodeBase;
		internal System.Windows.Forms.TabPage TabPageAssemblyDetails;
		internal System.Windows.Forms.ListView AssemblyDetailsListView;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ComboBox AssemblyNamesComboBox;
	}
}
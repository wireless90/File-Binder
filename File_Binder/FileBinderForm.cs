using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using File_Binder.Properties;
using Microsoft.CSharp;

namespace File_Binder
{
	public class FileBinderForm : Form
	{
		private IContainer components = null;

		private ListBox fileListBox;

		private Button addButton;

		private OpenFileDialog openFileDialog;

		private PictureBox pictureBox1;

		private PictureBox pictureBox3;

		private Button removeButton;

		private PictureBox pictureBox2;

		private Button bindButton;

		private PictureBox pictureBox4;

		private PictureBox pictureBox5;

		private Button editIconButton;

		private PictureBox pictureBox6;

		private OpenFileDialog openFileDialog2;

		private string strIconPath = "";

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(File_Binder.FileBinderForm));
			fileListBox = new System.Windows.Forms.ListBox();
			addButton = new System.Windows.Forms.Button();
			openFileDialog = new System.Windows.Forms.OpenFileDialog();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			removeButton = new System.Windows.Forms.Button();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			bindButton = new System.Windows.Forms.Button();
			pictureBox4 = new System.Windows.Forms.PictureBox();
			pictureBox5 = new System.Windows.Forms.PictureBox();
			editIconButton = new System.Windows.Forms.Button();
			pictureBox6 = new System.Windows.Forms.PictureBox();
			openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			SuspendLayout();
			fileListBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			fileListBox.Font = new System.Drawing.Font("Lucida Console", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			fileListBox.ForeColor = System.Drawing.Color.Red;
			fileListBox.FormattingEnabled = true;
			fileListBox.ItemHeight = 11;
			fileListBox.Location = new System.Drawing.Point(38, 64);
			fileListBox.Name = "fileListBox";
			fileListBox.Size = new System.Drawing.Size(408, 114);
			fileListBox.TabIndex = 0;
			addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			addButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			addButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("addButton.BackgroundImage");
			addButton.Font = new System.Drawing.Font("Lucida Console", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			addButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			addButton.Location = new System.Drawing.Point(12, 200);
			addButton.Name = "addButton";
			addButton.Size = new System.Drawing.Size(141, 22);
			addButton.TabIndex = 1;
			addButton.Text = "Add";
			addButton.UseVisualStyleBackColor = false;
			addButton.Click += new System.EventHandler(addButton_Click);
			openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(openFileDialog_FileOk);
			pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new System.Drawing.Point(1, 0);
			pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(305, 39);
			pictureBox1.TabIndex = 39;
			pictureBox1.TabStop = false;
			pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new System.Drawing.Point(8, 196);
			pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new System.Drawing.Size(149, 30);
			pictureBox3.TabIndex = 40;
			pictureBox3.TabStop = false;
			removeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			removeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			removeButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("removeButton.BackgroundImage");
			removeButton.Font = new System.Drawing.Font("Lucida Console", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			removeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			removeButton.Location = new System.Drawing.Point(171, 200);
			removeButton.Name = "removeButton";
			removeButton.Size = new System.Drawing.Size(141, 22);
			removeButton.TabIndex = 41;
			removeButton.Text = "Remove";
			removeButton.UseVisualStyleBackColor = false;
			removeButton.Click += new System.EventHandler(removeButton_Click);
			pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new System.Drawing.Point(167, 196);
			pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(149, 30);
			pictureBox2.TabIndex = 42;
			pictureBox2.TabStop = false;
			bindButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			bindButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			bindButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("bindButton.BackgroundImage");
			bindButton.Font = new System.Drawing.Font("Lucida Console", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bindButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			bindButton.Location = new System.Drawing.Point(171, 241);
			bindButton.Name = "bindButton";
			bindButton.Size = new System.Drawing.Size(141, 22);
			bindButton.TabIndex = 43;
			bindButton.Text = "Bind";
			bindButton.UseVisualStyleBackColor = false;
			bindButton.Click += new System.EventHandler(bindButton_Click);
			pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
			pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new System.Drawing.Point(167, 237);
			pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new System.Drawing.Size(149, 30);
			pictureBox4.TabIndex = 44;
			pictureBox4.TabStop = false;
			pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			pictureBox5.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox5.BackgroundImage");
			pictureBox5.Location = new System.Drawing.Point(143, 293);
			pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new System.Drawing.Size(340, 30);
			pictureBox5.TabIndex = 45;
			pictureBox5.TabStop = false;
			editIconButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			editIconButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			editIconButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("editIconButton.BackgroundImage");
			editIconButton.Font = new System.Drawing.Font("Lucida Console", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			editIconButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			editIconButton.Location = new System.Drawing.Point(331, 200);
			editIconButton.Name = "editIconButton";
			editIconButton.Size = new System.Drawing.Size(141, 22);
			editIconButton.TabIndex = 46;
			editIconButton.Text = "Edit Icon";
			editIconButton.UseVisualStyleBackColor = false;
			editIconButton.Click += new System.EventHandler(editIconButton_Click);
			pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
			pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
			pictureBox6.Location = new System.Drawing.Point(327, 196);
			pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new System.Drawing.Size(149, 30);
			pictureBox6.TabIndex = 47;
			pictureBox6.TabStop = false;
			openFileDialog2.Filter = "Icon Files|*.ico";
			openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(openFileDialog2_FileOk);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			base.ClientSize = new System.Drawing.Size(486, 326);
			base.Controls.Add(editIconButton);
			base.Controls.Add(pictureBox6);
			base.Controls.Add(pictureBox5);
			base.Controls.Add(bindButton);
			base.Controls.Add(pictureBox4);
			base.Controls.Add(removeButton);
			base.Controls.Add(pictureBox2);
			base.Controls.Add(pictureBox1);
			base.Controls.Add(addButton);
			base.Controls.Add(fileListBox);
			base.Controls.Add(pictureBox3);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "FileBinderForm";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "File Binder";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			ResumeLayout(false);
		}

		public FileBinderForm()
		{
			InitializeComponent();
		}

		private void openFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			fileListBox.Items.Add(openFileDialog.FileName);
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			openFileDialog.ShowDialog();
		}

		private void removeButton_Click(object sender, EventArgs e)
		{
			fileListBox.Items.RemoveAt(fileListBox.SelectedIndex);
		}

		private void bindButton_Click(object sender, EventArgs e)
		{
			string text = "";
			string text2 = "";
			ResourceWriter resourceWriter = new ResourceWriter("Binded.Resources");
			foreach (object item in fileListBox.Items)
			{
				FileInfo fileInfo = new FileInfo((string)item);
				string name = fileInfo.Name;
				string text3 = name + "Resource";
				string text4 = Resources.Dropcode.Replace("[FILENAME]", name);
				text4 = text4.Replace("[RESOURCENAME]", text3);
				text += text4;
				resourceWriter.AddResource(text3, File.ReadAllBytes(fileInfo.FullName));
			}
			resourceWriter.Close();
			text2 = Resources.CompileCode.Replace("[DROPCODE]", text);
			CompilerParameters compilerParameters = new CompilerParameters();
			compilerParameters.GenerateExecutable = true;
			compilerParameters.OutputAssembly = "binded.exe";
			compilerParameters.CompilerOptions = "/target:winexe";
			compilerParameters.EmbeddedResources.Add("Binded.Resources");
			compilerParameters.ReferencedAssemblies.Add("System.dll");
			CSharpCodeProvider cSharpCodeProvider = new CSharpCodeProvider();
			CompilerResults compilerResults = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, text2);
			File.Delete("Binded.Resources");
			if (compilerResults.Errors.Count > 0)
			{
				foreach (CompilerError error in compilerResults.Errors)
				{
					MessageBox.Show(error.ToString());
				}
			}
			if (strIconPath != "")
			{
				File.WriteAllBytes("ResHacker.exe", Resources.ResHacker);
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = "cmd.exe";
				processStartInfo.Arguments = "/c ResHacker.exe -addoverwrite \"binded.exe\", \"binded.exe\", \"" + strIconPath + "\", ICONGROUP, MAINICON, 0";
				processStartInfo.UseShellExecute = false;
				processStartInfo.CreateNoWindow = true;
				Process process = new Process();
				process.StartInfo = processStartInfo;
				process.Start();
				process.WaitForExit();
				string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "ResHacker*", SearchOption.TopDirectoryOnly);
				foreach (string path in files)
				{
					File.Delete(path);
				}
			}
			MessageBox.Show("Files binded successfully!!!", "File Binding", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void editIconButton_Click(object sender, EventArgs e)
		{
			openFileDialog2.ShowDialog();
		}

		private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
		{
			strIconPath = openFileDialog2.FileName;
		}
	}
}

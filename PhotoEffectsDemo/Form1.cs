using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

using Atalasoft.Imaging;
using Atalasoft.Imaging.Codec;
using Atalasoft.Imaging.ImageProcessing.Effects;

namespace PhotoEffectsDemo
{
	public class Form1 : System.Windows.Forms.Form
	{
		private string _fileName = null;

		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuFileOpen;
		private System.Windows.Forms.MenuItem menuFileSaveAs;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuExit;
		private Atalasoft.Imaging.WinControls.WorkspaceViewer viewerOriginal;
		private Atalasoft.Imaging.WinControls.WorkspaceViewer viewerModified;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusPosition;
		private System.Windows.Forms.StatusBarPanel statusColor;
		private System.Windows.Forms.StatusBarPanel statusInfo;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuEffects;
		private System.Windows.Forms.MenuItem menuEffectsLevels;
		private System.Windows.Forms.MenuItem menuEffectsCooler;
		private System.Windows.Forms.MenuItem menuEffectsWarmer;
		private System.Windows.Forms.MenuItem menuEffectsMagic;
		private System.Windows.Forms.MenuItem menuEffectCorrection;
		private System.Windows.Forms.MenuItem menuEffectMultiply;
		private System.Windows.Forms.MenuItem menuEffectPortrait;
		private System.Windows.Forms.MenuItem menuEffectShadowBoost;
		private System.Windows.Forms.MenuItem menuEffectsSkinTones;
		private System.Windows.Forms.MenuItem menuGradient;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuAbout;
		private System.Windows.Forms.MenuItem menuAboutDialog;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuEffectAutoLevels;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            AtalaDemos.HelperMethods.PopulateDecoders(RegisteredDecoders.Decoders);

			this.menuEffects.Enabled = false;
			this.menuFileSaveAs.Enabled = false;

			// This should point to the "DotImage 4.0\Images\PhotoEffects" folder.
			this._fileName = System.IO.Path.GetFullPath(@"..\..\Images\PhotoEffects\ColorMagicSample2.jpg");
			if (!System.IO.File.Exists(this._fileName))
			{
				this._fileName = System.IO.Path.GetFullPath(@"..\..\..\..\..\Images\PhotoEffects\ColorMagicSample2.jpg");
				if (!System.IO.File.Exists(this._fileName))	
					this._fileName = "";
			}
			
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuFileOpen = new System.Windows.Forms.MenuItem();
			this.menuFileSaveAs = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuExit = new System.Windows.Forms.MenuItem();
			this.menuEffects = new System.Windows.Forms.MenuItem();
			this.menuEffectAutoLevels = new System.Windows.Forms.MenuItem();
			this.menuEffectsLevels = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuEffectsCooler = new System.Windows.Forms.MenuItem();
			this.menuEffectsWarmer = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuEffectsMagic = new System.Windows.Forms.MenuItem();
			this.menuEffectCorrection = new System.Windows.Forms.MenuItem();
			this.menuEffectMultiply = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuEffectPortrait = new System.Windows.Forms.MenuItem();
			this.menuEffectShadowBoost = new System.Windows.Forms.MenuItem();
			this.menuEffectsSkinTones = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuGradient = new System.Windows.Forms.MenuItem();
			this.menuAbout = new System.Windows.Forms.MenuItem();
			this.menuAboutDialog = new System.Windows.Forms.MenuItem();
			this.viewerOriginal = new Atalasoft.Imaging.WinControls.WorkspaceViewer();
			this.viewerModified = new Atalasoft.Imaging.WinControls.WorkspaceViewer();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusPosition = new System.Windows.Forms.StatusBarPanel();
			this.statusColor = new System.Windows.Forms.StatusBarPanel();
			this.statusInfo = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.statusPosition)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusColor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusInfo)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuFile,
																					  this.menuEffects,
																					  this.menuAbout});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuFileOpen,
																					 this.menuFileSaveAs,
																					 this.menuItem4,
																					 this.menuExit});
			this.menuFile.Text = "&File";
			// 
			// menuFileOpen
			// 
			this.menuFileOpen.Index = 0;
			this.menuFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.menuFileOpen.Text = "&Open";
			this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
			// 
			// menuFileSaveAs
			// 
			this.menuFileSaveAs.Index = 1;
			this.menuFileSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.menuFileSaveAs.Text = "&Save As...";
			this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "-";
			// 
			// menuExit
			// 
			this.menuExit.Index = 3;
			this.menuExit.Text = "E&xit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// menuEffects
			// 
			this.menuEffects.Index = 1;
			this.menuEffects.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menuEffectAutoLevels,
																						this.menuEffectsLevels,
																						this.menuItem3,
																						this.menuEffectsCooler,
																						this.menuEffectsWarmer,
																						this.menuItem1,
																						this.menuEffectsMagic,
																						this.menuEffectCorrection,
																						this.menuEffectMultiply,
																						this.menuItem2,
																						this.menuEffectPortrait,
																						this.menuEffectShadowBoost,
																						this.menuEffectsSkinTones,
																						this.menuItem5,
																						this.menuGradient});
			this.menuEffects.Text = "&Effects";
			// 
			// menuEffectAutoLevels
			// 
			this.menuEffectAutoLevels.Index = 0;
			this.menuEffectAutoLevels.Text = "Auto Levels";
			this.menuEffectAutoLevels.Click += new System.EventHandler(this.menuEffectAutoLevels_Click);
			// 
			// menuEffectsLevels
			// 
			this.menuEffectsLevels.Index = 1;
			this.menuEffectsLevels.Text = "&Levels";
			this.menuEffectsLevels.Click += new System.EventHandler(this.menuEffectsLevels_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "-";
			// 
			// menuEffectsCooler
			// 
			this.menuEffectsCooler.Index = 3;
			this.menuEffectsCooler.Text = "&Cooler";
			this.menuEffectsCooler.Click += new System.EventHandler(this.menuEffectsCooler_Click);
			// 
			// menuEffectsWarmer
			// 
			this.menuEffectsWarmer.Index = 4;
			this.menuEffectsWarmer.Text = "&Warmer";
			this.menuEffectsWarmer.Click += new System.EventHandler(this.menuEffectsWarmer_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 5;
			this.menuItem1.Text = "-";
			// 
			// menuEffectsMagic
			// 
			this.menuEffectsMagic.Index = 6;
			this.menuEffectsMagic.Text = "Color Magic";
			this.menuEffectsMagic.Click += new System.EventHandler(this.menuEffectsMagic_Click);
			// 
			// menuEffectCorrection
			// 
			this.menuEffectCorrection.Index = 7;
			this.menuEffectCorrection.Text = "Correction";
			this.menuEffectCorrection.Click += new System.EventHandler(this.menuEffectCorrection_Click);
			// 
			// menuEffectMultiply
			// 
			this.menuEffectMultiply.Index = 8;
			this.menuEffectMultiply.Text = "Multiply";
			this.menuEffectMultiply.Click += new System.EventHandler(this.menuEffectMultiply_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 9;
			this.menuItem2.Text = "-";
			// 
			// menuEffectPortrait
			// 
			this.menuEffectPortrait.Index = 10;
			this.menuEffectPortrait.Text = "Portrait";
			this.menuEffectPortrait.Click += new System.EventHandler(this.menuEffectPortrait_Click);
			// 
			// menuEffectShadowBoost
			// 
			this.menuEffectShadowBoost.Index = 11;
			this.menuEffectShadowBoost.Text = "Shadow Boost";
			this.menuEffectShadowBoost.Click += new System.EventHandler(this.menuEffectShadowBoost_Click);
			// 
			// menuEffectsSkinTones
			// 
			this.menuEffectsSkinTones.Index = 12;
			this.menuEffectsSkinTones.Text = "Skin Tones";
			this.menuEffectsSkinTones.Click += new System.EventHandler(this.menuEffectsSkinTones_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 13;
			this.menuItem5.Text = "-";
			// 
			// menuGradient
			// 
			this.menuGradient.Index = 14;
			this.menuGradient.Text = "Gradient";
			this.menuGradient.Click += new System.EventHandler(this.menuGradient_Click);
			// 
			// menuAbout
			// 
			this.menuAbout.Index = 2;
			this.menuAbout.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuAboutDialog});
			this.menuAbout.Text = "&About";
			// 
			// menuAboutDialog
			// 
			this.menuAboutDialog.Index = 0;
			this.menuAboutDialog.Text = "Advanced Photo Effects Demo...";
			this.menuAboutDialog.Click += new System.EventHandler(this.menuAboutDialog_Click);
			// 
			// viewerOriginal
			// 
			this.viewerOriginal.AutoZoom = Atalasoft.Imaging.WinControls.AutoZoomMode.BestFitShrinkOnly;
			this.viewerOriginal.BackColor = System.Drawing.Color.White;
			this.viewerOriginal.Centered = true;
			this.viewerOriginal.DisplayProfile = null;
			this.viewerOriginal.Location = new System.Drawing.Point(8, 8);
			this.viewerOriginal.Magnifier.BackColor = System.Drawing.Color.White;
			this.viewerOriginal.Magnifier.BorderColor = System.Drawing.Color.Black;
			this.viewerOriginal.Magnifier.Size = new System.Drawing.Size(100, 100);
			this.viewerOriginal.MouseTool = Atalasoft.Imaging.WinControls.MouseToolType.Magnifier;
			this.viewerOriginal.Name = "viewerOriginal";
			this.viewerOriginal.OutputProfile = null;
			this.viewerOriginal.ScrollPosition = new System.Drawing.Point(144, 212);
			this.viewerOriginal.Selection = null;
			this.viewerOriginal.Size = new System.Drawing.Size(288, 424);
			this.viewerOriginal.TabIndex = 0;
			this.viewerOriginal.Text = "workspaceViewer1";
			this.viewerOriginal.MouseMovePixel += new System.Windows.Forms.MouseEventHandler(this.viewerOriginal_MouseMovePixel);
			this.viewerOriginal.MouseLeave += new System.EventHandler(this.viewer_MouseLeave);
			// 
			// viewerModified
			// 
			this.viewerModified.AutoZoom = Atalasoft.Imaging.WinControls.AutoZoomMode.BestFitShrinkOnly;
			this.viewerModified.BackColor = System.Drawing.Color.White;
			this.viewerModified.Centered = true;
			this.viewerModified.DisplayProfile = null;
			this.viewerModified.Location = new System.Drawing.Point(312, 8);
			this.viewerModified.Magnifier.BackColor = System.Drawing.Color.White;
			this.viewerModified.Magnifier.BorderColor = System.Drawing.Color.Black;
			this.viewerModified.Magnifier.Size = new System.Drawing.Size(100, 100);
			this.viewerModified.MouseTool = Atalasoft.Imaging.WinControls.MouseToolType.Magnifier;
			this.viewerModified.Name = "viewerModified";
			this.viewerModified.OutputProfile = null;
			this.viewerModified.ScrollPosition = new System.Drawing.Point(144, 212);
			this.viewerModified.Selection = null;
			this.viewerModified.Size = new System.Drawing.Size(288, 424);
			this.viewerModified.TabIndex = 1;
			this.viewerModified.Text = "workspaceViewer2";
			this.viewerModified.MouseMovePixel += new System.Windows.Forms.MouseEventHandler(this.viewerModified_MouseMovePixel);
			this.viewerModified.MouseLeave += new System.EventHandler(this.viewer_MouseLeave);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 435);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusPosition,
																						  this.statusColor,
																						  this.statusInfo});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(608, 22);
			this.statusBar1.TabIndex = 2;
			// 
			// statusPosition
			// 
			this.statusPosition.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.statusPosition.Text = "-";
			// 
			// statusColor
			// 
			this.statusColor.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.statusColor.Text = "-";
			this.statusColor.Width = 200;
			// 
			// statusInfo
			// 
			this.statusInfo.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusInfo.Width = 292;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(608, 457);
			this.Controls.Add(this.viewerModified);
			this.Controls.Add(this.viewerOriginal);
			this.Controls.Add(this.statusBar1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(464, 376);
			this.Name = "Form1";
			this.Text = "Advanced Photo Effects Demo";
			this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
			((System.ComponentModel.ISupportInitialize)(this.statusPosition)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusColor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusInfo)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		#region File Menu

		private void menuFileOpen_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = AtalaDemos.HelperMethods.CreateDialogFilter(true);
			dlg.FileName = this._fileName;

			// try to locate images folder
			string imagesFolder = Application.ExecutablePath;
			// we assume we are running under the DotImage install folder
			int pos = imagesFolder.IndexOf("DotImage ");
			if (pos != -1)
			{
				imagesFolder = imagesFolder.Substring(0,imagesFolder.IndexOf(@"\",pos)) + @"\Images\PhotoEffects";
			}

			//use this folder as starting point			
			dlg.InitialDirectory = imagesFolder;

			try
			{
				if (dlg.ShowDialog(this) == DialogResult.OK)
				{
					try
					{
						this._fileName = dlg.FileName;
						this.viewerModified.Images.Clear();
						this.viewerOriginal.Images.Clear();
						this.statusColor.Text = "-";
						this.statusInfo.Text = "";
						this.statusPosition.Text = "-";

						if (System.IO.File.Exists(this._fileName))
							this.viewerOriginal.Open(this._fileName, 0);

						if (this.viewerOriginal.Image != null)
							this.menuEffects.Enabled = true;
					}
					catch (Exception ex)
					{
						MessageBox.Show(this, ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			finally
			{
				dlg.Dispose();
			}
		}

		private void menuFileSaveAs_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "Joint Photographic Experts Group (*.jpg)|*.jpg|Tagged Image File (*.tif)|*.tif|Portable Network Graphic (*.png)|*.png|Adobe (tm) Photoshop format (*.psd)|*.psd";

			try
			{
				if (dlg.ShowDialog(this) == DialogResult.OK)
				{
					ImageEncoder encoder = null;

					switch (dlg.FilterIndex)
					{
						case 1:
							encoder = new JpegEncoder(85, 0, false);
							break;
						case 2:
							encoder = new TiffEncoder(TiffCompression.Default, false);
							break;
						case 3:
							encoder = new PngEncoder();
							break;
						case 4:
							encoder = new PsdEncoder();
							break;
					}

					try
					{
						this.viewerModified.Save(dlg.FileName, encoder, 0);
					}
					catch (Exception ex)
					{
						MessageBox.Show(this, ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			finally
			{
				dlg.Dispose();
			}
		}

		private void menuExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region Events

		private void Form1_Layout(object sender, System.Windows.Forms.LayoutEventArgs e)
		{
			// calculate the viewer size.
			int width = (this.ClientSize.Width - 24) / 2;
			int height = this.ClientSize.Height - 16 - this.statusBar1.Height;

			this.viewerOriginal.Size = new Size(width, height);
			this.viewerModified.Size = new Size(width, height);
			this.viewerModified.Location = new Point(width + 16, 8);
		}

		private void viewerOriginal_MouseMovePixel(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			SetStatus(e, this.viewerOriginal.Image);
		}

		private void viewerModified_MouseMovePixel(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			SetStatus(e, this.viewerModified.Image);
		}

		private void SetStatus(System.Windows.Forms.MouseEventArgs e, AtalaImage image)
		{
			this.statusPosition.Text = "X: " + e.X.ToString() + ", Y: " + e.Y.ToString();

			if (image.PixelFormat == PixelFormat.Pixel32bppCmyk)
			{
				CmykColor cmy = image.GetPixelCmykColor(e.X, e.Y);
				this.statusColor.Text = "C: " + cmy.C.ToString() + ", M: " + cmy.M.ToString() + ", Y: " + cmy.Y.ToString() + ", K: " + cmy.K.ToString();
			}
			else
			{
				Color clr = image.GetPixelColor(e.X, e.Y);
				this.statusColor.Text = "A: " + clr.A.ToString() + ",R: " + clr.R.ToString() + ", G: " + clr.G.ToString() + ", B: " + clr.B.ToString();
			}
		}

		private void viewer_MouseLeave(object sender, System.EventArgs e)
		{
			this.statusColor.Text = "-";
			this.statusPosition.Text = "-";
		}

		#endregion

		#region Effects Menu

		private void menuEffectAutoLevels_Click(object sender, System.EventArgs e)
		{
			ApplyCommandDialog(new AutoLevelsCommand());
		}

		private void menuEffectsLevels_Click(object sender, System.EventArgs e)
		{
			ApplyCommandDialog(new AdvancedLevelsCommand());
		}

		private void menuEffectsCooler_Click(object sender, System.EventArgs e)
		{
			ApplyCommandDialog(new PhotoColorCoolerCommand());
		}

		private void menuEffectsWarmer_Click(object sender, System.EventArgs e)
		{
			ApplyCommandDialog(new PhotoColorWarmerCommand());
		}

		private void menuEffectsMagic_Click(object sender, System.EventArgs e)
		{
			ApplyCommandDialog(new PhotoColorMagicCommand());
		}

		private void menuEffectCorrection_Click(object sender, System.EventArgs e)
		{
			ApplyCommandDialog(new PhotoColorCorrectCommand());
		}

		private void menuEffectMultiply_Click(object sender, System.EventArgs e)
		{
			ApplyCommandDialog(new PhotoColorMultiplyCommand());
		}

		private void menuEffectPortrait_Click(object sender, System.EventArgs e)
		{
			// This command does not have extra properties, so just apply it.
			ApplyCommand(new PhotoPortraitCommand());
		}

		private void menuEffectShadowBoost_Click(object sender, System.EventArgs e)
		{
			// This command does not have extra properties, so just apply it.
			ApplyCommand(new PhotoShadowBoostCommand());
		}

		private void menuEffectsSkinTones_Click(object sender, System.EventArgs e)
		{
			// This command does not have extra properties, so just apply it.
			ApplyCommand(new PhotoSkinTonesCommand());
		}

		private void menuGradient_Click(object sender, System.EventArgs e)
		{
			ApplyCommandDialog(new NDGradFilterCommand());
		}

		private void ApplyCommandDialog(Atalasoft.Imaging.ImageProcessing.ImageCommand command)
		{
			PropertiesDialog dlg = new PropertiesDialog(command);
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				ApplyCommand(command);
			}
			dlg.Dispose();
		}

		private void ApplyCommand(Atalasoft.Imaging.ImageProcessing.ImageCommand command)
		{
			this.Cursor = Cursors.WaitCursor;
			this.viewerModified.Images.Clear();
			this.viewerModified.Images.Add((AtalaImage)this.viewerOriginal.Image.Clone());
			this.viewerModified.ApplyCommand(command);
			this.Cursor = Cursors.Default;

			this.menuFileSaveAs.Enabled = (this.viewerModified.Image != null);
		}

		#endregion

		private void menuAboutDialog_Click(object sender, System.EventArgs e)
		{
			AtalaDemos.AboutBox.About frm = new AtalaDemos.AboutBox.About("About...", "Advanced Photo Effects Demo");
			frm.Description = "This demo uses Atalasoft DotImage and the Advanced Photo Effects add-on to apply color enhancement and correction effects on color images.";
			frm.ShowDialog(this);
			frm.Dispose();
		}

	}
}

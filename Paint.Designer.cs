namespace Paint
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_New = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Copy = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Cut = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Undo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Redo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_TextFont = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_ForeColor = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_ColorText = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip_TextForeColor = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip_BackColor = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_TextBackColor = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLb_penSize = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Zigzag = new System.Windows.Forms.Button();
            this.btn_Selection = new System.Windows.Forms.Button();
            this.btn_TextTool = new System.Windows.Forms.Button();
            this.btn_Bezier = new System.Windows.Forms.Button();
            this.btn_Polygon = new System.Windows.Forms.Button();
            this.btn_Scale = new System.Windows.Forms.Button();
            this.btn_Rotate = new System.Windows.Forms.Button();
            this.btn_Move = new System.Windows.Forms.Button();
            this.btn_pencilSize = new System.Windows.Forms.Button();
            this.lb_positionMouse = new System.Windows.Forms.Label();
            this.btn_Hyperbola = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_Parabola = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.btn_Line = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Eye = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.listView_layer = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_Layer = new System.Windows.Forms.Label();
            this.lb_Mouse = new System.Windows.Forms.Label();
            this.pencilSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_DashStyle = new System.Windows.Forms.ComboBox();
            this.btn_ParamSet = new System.Windows.Forms.Button();
            this.mainDrawingPicture = new System.Windows.Forms.PictureBox();
            this.comboBox_FillType = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pencilSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDrawingPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.toolStrip_Save_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_New,
            this.toolStrip_Open,
            this.toolStrip_Save,
            this.toolStrip_Copy,
            this.toolStrip_Cut,
            this.toolStrip_Undo,
            this.toolStrip_Redo,
            this.toolStrip_TextFont,
            this.toolStrip_ForeColor,
            this.toolStrip_ColorText,
            this.toolStripLabel1,
            this.toolStrip_TextForeColor,
            this.toolStrip_BackColor,
            this.toolStrip_TextBackColor,
            this.toolStripLb_penSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip_New
            // 
            this.toolStrip_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_New.Image = global::Paint.Properties.Resources.new_btn;
            this.toolStrip_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_New.Name = "toolStrip_New";
            this.toolStrip_New.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_New.Tag = "New";
            this.toolStrip_New.Click += new System.EventHandler(this.toolStrip_New_Click);
            // 
            // toolStrip_Open
            // 
            this.toolStrip_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Open.Image = global::Paint.Properties.Resources.open_btn;
            this.toolStrip_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Open.Name = "toolStrip_Open";
            this.toolStrip_Open.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Open.Tag = "Open";
            this.toolStrip_Open.Click += new System.EventHandler(this.toolStrip_Open_Click);
            // 
            // toolStrip_Save
            // 
            this.toolStrip_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Save.Image = global::Paint.Properties.Resources.save_btn;
            this.toolStrip_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Save.Name = "toolStrip_Save";
            this.toolStrip_Save.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Save.Tag = "Save";
            this.toolStrip_Save.Click += new System.EventHandler(this.toolStrip_Save_Click);
            // 
            // toolStrip_Copy
            // 
            this.toolStrip_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Copy.Image = global::Paint.Properties.Resources.copy;
            this.toolStrip_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Copy.Name = "toolStrip_Copy";
            this.toolStrip_Copy.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Copy.Text = "toolStrip_Copy";
            this.toolStrip_Copy.Click += new System.EventHandler(this.toolStrip_Copy_Click);
            // 
            // toolStrip_Cut
            // 
            this.toolStrip_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Cut.Image = global::Paint.Properties.Resources.cut;
            this.toolStrip_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Cut.Name = "toolStrip_Cut";
            this.toolStrip_Cut.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Cut.Text = "toolStrip_Cut";
            this.toolStrip_Cut.Click += new System.EventHandler(this.toolStrip_Cut_Click);
            // 
            // toolStrip_Undo
            // 
            this.toolStrip_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Undo.Image = global::Paint.Properties.Resources.undo;
            this.toolStrip_Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Undo.Name = "toolStrip_Undo";
            this.toolStrip_Undo.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Undo.Text = "toolStrip_Undo";
            this.toolStrip_Undo.Click += new System.EventHandler(this.toolStrip_Undo_Click);
            // 
            // toolStrip_Redo
            // 
            this.toolStrip_Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Redo.Image = global::Paint.Properties.Resources.redo;
            this.toolStrip_Redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Redo.Name = "toolStrip_Redo";
            this.toolStrip_Redo.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Redo.Text = "toolStrip_Redo";
            this.toolStrip_Redo.Click += new System.EventHandler(this.toolStrip_Redo_Click);
            // 
            // toolStrip_TextFont
            // 
            this.toolStrip_TextFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip_TextFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_TextFont.Image = global::Paint.Properties.Resources.text1;
            this.toolStrip_TextFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_TextFont.Name = "toolStrip_TextFont";
            this.toolStrip_TextFont.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_TextFont.Tag = "Text";
            this.toolStrip_TextFont.Click += new System.EventHandler(this.toolStrip_TextFont_Click);
            // 
            // toolStrip_ForeColor
            // 
            this.toolStrip_ForeColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip_ForeColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_ForeColor.Image = global::Paint.Properties.Resources.borderShape;
            this.toolStrip_ForeColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_ForeColor.Name = "toolStrip_ForeColor";
            this.toolStrip_ForeColor.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_ForeColor.Tag = "Color";
            this.toolStrip_ForeColor.Click += new System.EventHandler(this.toolStrip_Color_Click);
            // 
            // toolStrip_ColorText
            // 
            this.toolStrip_ColorText.Name = "toolStrip_ColorText";
            this.toolStrip_ColorText.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStrip_TextForeColor
            // 
            this.toolStrip_TextForeColor.Name = "toolStrip_TextForeColor";
            this.toolStrip_TextForeColor.ReadOnly = true;
            this.toolStrip_TextForeColor.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStrip_BackColor
            // 
            this.toolStrip_BackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_BackColor.Image = global::Paint.Properties.Resources.solidShape;
            this.toolStrip_BackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_BackColor.Name = "toolStrip_BackColor";
            this.toolStrip_BackColor.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_BackColor.Text = "toolStripButton1";
            this.toolStrip_BackColor.Click += new System.EventHandler(this.toolStrip_BackColor_Click);
            // 
            // toolStrip_TextBackColor
            // 
            this.toolStrip_TextBackColor.Name = "toolStrip_TextBackColor";
            this.toolStrip_TextBackColor.ReadOnly = true;
            this.toolStrip_TextBackColor.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLb_penSize
            // 
            this.toolStripLb_penSize.Name = "toolStripLb_penSize";
            this.toolStripLb_penSize.Size = new System.Drawing.Size(65, 22);
            this.toolStripLb_penSize.Text = "Pencil Size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Zigzag);
            this.groupBox1.Controls.Add(this.btn_Selection);
            this.groupBox1.Controls.Add(this.btn_TextTool);
            this.groupBox1.Controls.Add(this.btn_Bezier);
            this.groupBox1.Controls.Add(this.btn_Polygon);
            this.groupBox1.Controls.Add(this.btn_Scale);
            this.groupBox1.Controls.Add(this.btn_Rotate);
            this.groupBox1.Controls.Add(this.btn_Move);
            this.groupBox1.Controls.Add(this.btn_pencilSize);
            this.groupBox1.Controls.Add(this.lb_positionMouse);
            this.groupBox1.Controls.Add(this.btn_Hyperbola);
            this.groupBox1.Controls.Add(this.btn_Circle);
            this.groupBox1.Controls.Add(this.btn_Parabola);
            this.groupBox1.Controls.Add(this.btn_Rectangle);
            this.groupBox1.Controls.Add(this.btn_Line);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 555);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tool";
            // 
            // btn_Zigzag
            // 
            this.btn_Zigzag.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Zigzag.BackgroundImage = global::Paint.Properties.Resources.zigzag;
            this.btn_Zigzag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Zigzag.Location = new System.Drawing.Point(56, 142);
            this.btn_Zigzag.Name = "btn_Zigzag";
            this.btn_Zigzag.Size = new System.Drawing.Size(40, 35);
            this.btn_Zigzag.TabIndex = 16;
            this.btn_Zigzag.Tag = "Zigzag";
            this.btn_Zigzag.UseVisualStyleBackColor = false;
            this.btn_Zigzag.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // btn_Selection
            // 
            this.btn_Selection.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Selection.BackgroundImage = global::Paint.Properties.Resources.cursor;
            this.btn_Selection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Selection.Location = new System.Drawing.Point(57, 183);
            this.btn_Selection.Name = "btn_Selection";
            this.btn_Selection.Size = new System.Drawing.Size(39, 35);
            this.btn_Selection.TabIndex = 15;
            this.btn_Selection.Tag = "Selection";
            this.btn_Selection.UseVisualStyleBackColor = false;
            this.btn_Selection.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // btn_TextTool
            // 
            this.btn_TextTool.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_TextTool.BackgroundImage = global::Paint.Properties.Resources.text;
            this.btn_TextTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TextTool.Location = new System.Drawing.Point(7, 183);
            this.btn_TextTool.Name = "btn_TextTool";
            this.btn_TextTool.Size = new System.Drawing.Size(39, 35);
            this.btn_TextTool.TabIndex = 14;
            this.btn_TextTool.Tag = "Text";
            this.btn_TextTool.UseVisualStyleBackColor = false;
            this.btn_TextTool.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // btn_Bezier
            // 
            this.btn_Bezier.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Bezier.BackgroundImage = global::Paint.Properties.Resources.bezier;
            this.btn_Bezier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Bezier.Location = new System.Drawing.Point(5, 142);
            this.btn_Bezier.Name = "btn_Bezier";
            this.btn_Bezier.Size = new System.Drawing.Size(40, 35);
            this.btn_Bezier.TabIndex = 13;
            this.btn_Bezier.Tag = "Bezier";
            this.btn_Bezier.UseVisualStyleBackColor = false;
            this.btn_Bezier.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // btn_Polygon
            // 
            this.btn_Polygon.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Polygon.BackgroundImage = global::Paint.Properties.Resources.polygon;
            this.btn_Polygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Polygon.Location = new System.Drawing.Point(57, 60);
            this.btn_Polygon.Name = "btn_Polygon";
            this.btn_Polygon.Size = new System.Drawing.Size(39, 35);
            this.btn_Polygon.TabIndex = 12;
            this.btn_Polygon.Tag = "Polygon";
            this.btn_Polygon.UseVisualStyleBackColor = false;
            this.btn_Polygon.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // btn_Scale
            // 
            this.btn_Scale.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Scale.BackgroundImage = global::Paint.Properties.Resources.scale;
            this.btn_Scale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Scale.Location = new System.Drawing.Point(6, 268);
            this.btn_Scale.Name = "btn_Scale";
            this.btn_Scale.Size = new System.Drawing.Size(39, 35);
            this.btn_Scale.TabIndex = 11;
            this.btn_Scale.Tag = "Scale";
            this.btn_Scale.UseVisualStyleBackColor = false;
            this.btn_Scale.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // btn_Rotate
            // 
            this.btn_Rotate.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Rotate.BackgroundImage = global::Paint.Properties.Resources.rotate;
            this.btn_Rotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Rotate.Location = new System.Drawing.Point(57, 224);
            this.btn_Rotate.Name = "btn_Rotate";
            this.btn_Rotate.Size = new System.Drawing.Size(39, 35);
            this.btn_Rotate.TabIndex = 10;
            this.btn_Rotate.Tag = "Rotate";
            this.btn_Rotate.UseVisualStyleBackColor = false;
            this.btn_Rotate.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // btn_Move
            // 
            this.btn_Move.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Move.BackgroundImage = global::Paint.Properties.Resources.move;
            this.btn_Move.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Move.Location = new System.Drawing.Point(6, 224);
            this.btn_Move.Name = "btn_Move";
            this.btn_Move.Size = new System.Drawing.Size(39, 35);
            this.btn_Move.TabIndex = 9;
            this.btn_Move.Tag = "Move";
            this.btn_Move.UseVisualStyleBackColor = false;
            this.btn_Move.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // btn_pencilSize
            // 
            this.btn_pencilSize.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_pencilSize.BackgroundImage = global::Paint.Properties.Resources.pensize;
            this.btn_pencilSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pencilSize.Location = new System.Drawing.Point(58, 265);
            this.btn_pencilSize.Name = "btn_pencilSize";
            this.btn_pencilSize.Size = new System.Drawing.Size(39, 35);
            this.btn_pencilSize.TabIndex = 8;
            this.btn_pencilSize.Tag = "Size";
            this.btn_pencilSize.UseVisualStyleBackColor = false;
            this.btn_pencilSize.Click += new System.EventHandler(this.btn_pencilSize_Click);
            // 
            // lb_positionMouse
            // 
            this.lb_positionMouse.AutoSize = true;
            this.lb_positionMouse.Location = new System.Drawing.Point(3, 542);
            this.lb_positionMouse.Name = "lb_positionMouse";
            this.lb_positionMouse.Size = new System.Drawing.Size(0, 13);
            this.lb_positionMouse.TabIndex = 6;
            // 
            // btn_Hyperbola
            // 
            this.btn_Hyperbola.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Hyperbola.BackgroundImage = global::Paint.Properties.Resources.hyperbola;
            this.btn_Hyperbola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Hyperbola.Location = new System.Drawing.Point(56, 101);
            this.btn_Hyperbola.Name = "btn_Hyperbola";
            this.btn_Hyperbola.Size = new System.Drawing.Size(40, 35);
            this.btn_Hyperbola.TabIndex = 5;
            this.btn_Hyperbola.Tag = "Hyperbola";
            this.btn_Hyperbola.UseVisualStyleBackColor = false;
            this.btn_Hyperbola.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Circle.BackgroundImage = global::Paint.Properties.Resources.circle;
            this.btn_Circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Circle.Location = new System.Drawing.Point(57, 19);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(40, 35);
            this.btn_Circle.TabIndex = 4;
            this.btn_Circle.Tag = "Circle";
            this.btn_Circle.UseVisualStyleBackColor = false;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // btn_Parabola
            // 
            this.btn_Parabola.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Parabola.BackgroundImage = global::Paint.Properties.Resources.parabola1;
            this.btn_Parabola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Parabola.Location = new System.Drawing.Point(5, 101);
            this.btn_Parabola.Name = "btn_Parabola";
            this.btn_Parabola.Size = new System.Drawing.Size(40, 35);
            this.btn_Parabola.TabIndex = 2;
            this.btn_Parabola.Tag = "Parabola";
            this.btn_Parabola.UseVisualStyleBackColor = false;
            this.btn_Parabola.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Rectangle.BackgroundImage = global::Paint.Properties.Resources.rectangle1;
            this.btn_Rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Rectangle.Location = new System.Drawing.Point(6, 60);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(39, 35);
            this.btn_Rectangle.TabIndex = 1;
            this.btn_Rectangle.Tag = "Rectangle";
            this.btn_Rectangle.UseVisualStyleBackColor = false;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // btn_Line
            // 
            this.btn_Line.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Line.BackgroundImage = global::Paint.Properties.Resources.line;
            this.btn_Line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Line.Location = new System.Drawing.Point(6, 19);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(40, 35);
            this.btn_Line.TabIndex = 0;
            this.btn_Line.Tag = "Line";
            this.btn_Line.UseVisualStyleBackColor = false;
            this.btn_Line.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_Down);
            this.groupBox2.Controls.Add(this.btn_Up);
            this.groupBox2.Controls.Add(this.btn_Eye);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.listView_layer);
            this.groupBox2.Location = new System.Drawing.Point(886, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 261);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Layer";
            // 
            // btn_Down
            // 
            this.btn_Down.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Down.BackgroundImage = global::Paint.Properties.Resources.down;
            this.btn_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Down.Enabled = false;
            this.btn_Down.Location = new System.Drawing.Point(231, 216);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(40, 35);
            this.btn_Down.TabIndex = 5;
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Up.BackgroundImage = global::Paint.Properties.Resources.Up;
            this.btn_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Up.Enabled = false;
            this.btn_Up.Location = new System.Drawing.Point(180, 216);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(40, 35);
            this.btn_Up.TabIndex = 4;
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // btn_Eye
            // 
            this.btn_Eye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Eye.BackgroundImage = global::Paint.Properties.Resources.eye;
            this.btn_Eye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eye.Enabled = false;
            this.btn_Eye.Location = new System.Drawing.Point(125, 216);
            this.btn_Eye.Name = "btn_Eye";
            this.btn_Eye.Size = new System.Drawing.Size(40, 35);
            this.btn_Eye.TabIndex = 3;
            this.btn_Eye.UseVisualStyleBackColor = true;
            this.btn_Eye.Click += new System.EventHandler(this.btn_Eye_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackgroundImage = global::Paint.Properties.Resources.delete1;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(73, 216);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(40, 35);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = global::Paint.Properties.Resources.add;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add.Enabled = false;
            this.btn_Add.Location = new System.Drawing.Point(16, 216);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(40, 35);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.UseMnemonic = false;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // listView_layer
            // 
            this.listView_layer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_layer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_layer.HideSelection = false;
            this.listView_layer.LabelEdit = true;
            this.listView_layer.Location = new System.Drawing.Point(0, 20);
            this.listView_layer.MultiSelect = false;
            this.listView_layer.Name = "listView_layer";
            this.listView_layer.ShowGroups = false;
            this.listView_layer.Size = new System.Drawing.Size(285, 190);
            this.listView_layer.TabIndex = 16;
            this.listView_layer.UseCompatibleStateImageBehavior = false;
            this.listView_layer.View = System.Windows.Forms.View.List;
            this.listView_layer.SelectedIndexChanged += new System.EventHandler(this.listView_layer_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lb_Layer);
            this.groupBox3.Controls.Add(this.lb_Mouse);
            this.groupBox3.Location = new System.Drawing.Point(886, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 115);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User ";
            // 
            // lb_Layer
            // 
            this.lb_Layer.AutoSize = true;
            this.lb_Layer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Layer.Location = new System.Drawing.Point(21, 55);
            this.lb_Layer.Name = "lb_Layer";
            this.lb_Layer.Size = new System.Drawing.Size(59, 17);
            this.lb_Layer.TabIndex = 1;
            this.lb_Layer.Text = "Layer: ";
            // 
            // lb_Mouse
            // 
            this.lb_Mouse.AutoSize = true;
            this.lb_Mouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mouse.Location = new System.Drawing.Point(21, 27);
            this.lb_Mouse.Name = "lb_Mouse";
            this.lb_Mouse.Size = new System.Drawing.Size(128, 17);
            this.lb_Mouse.TabIndex = 0;
            this.lb_Mouse.Text = "Mouse Position: ";
            // 
            // pencilSize
            // 
            this.pencilSize.Location = new System.Drawing.Point(510, 29);
            this.pencilSize.Name = "pencilSize";
            this.pencilSize.Size = new System.Drawing.Size(48, 20);
            this.pencilSize.TabIndex = 6;
            this.pencilSize.ValueChanged += new System.EventHandler(this.pencilSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dash Style:";
            // 
            // comboBox_DashStyle
            // 
            this.comboBox_DashStyle.FormattingEnabled = true;
            this.comboBox_DashStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot",
            "Custom"});
            this.comboBox_DashStyle.Location = new System.Drawing.Point(631, 27);
            this.comboBox_DashStyle.Name = "comboBox_DashStyle";
            this.comboBox_DashStyle.Size = new System.Drawing.Size(122, 21);
            this.comboBox_DashStyle.TabIndex = 8;
            this.comboBox_DashStyle.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_ParamSet
            // 
            this.btn_ParamSet.Location = new System.Drawing.Point(886, 25);
            this.btn_ParamSet.Name = "btn_ParamSet";
            this.btn_ParamSet.Size = new System.Drawing.Size(52, 23);
            this.btn_ParamSet.TabIndex = 9;
            this.btn_ParamSet.Text = "Set";
            this.btn_ParamSet.UseVisualStyleBackColor = true;
            this.btn_ParamSet.Click += new System.EventHandler(this.btn_ParamSet_Click);
            // 
            // mainDrawingPicture
            // 
            this.mainDrawingPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDrawingPicture.BackColor = System.Drawing.Color.White;
            this.mainDrawingPicture.BackgroundImage = global::Paint.Properties.Resources.Transparency10;
            this.mainDrawingPicture.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mainDrawingPicture.Enabled = false;
            this.mainDrawingPicture.Location = new System.Drawing.Point(130, 52);
            this.mainDrawingPicture.Name = "mainDrawingPicture";
            this.mainDrawingPicture.Size = new System.Drawing.Size(0, 0);
            this.mainDrawingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainDrawingPicture.TabIndex = 3;
            this.mainDrawingPicture.TabStop = false;
            this.mainDrawingPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainDrawingPicture_MouseClick);
            this.mainDrawingPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainDrawingPicture_MouseDown);
            this.mainDrawingPicture.MouseLeave += new System.EventHandler(this.mainDrawingPicture_MouseLeave);
            this.mainDrawingPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainDrawingPicture_MouseMove);
            this.mainDrawingPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainDrawingPicture_MouseUp);
            // 
            // comboBox_FillType
            // 
            this.comboBox_FillType.FormattingEnabled = true;
            this.comboBox_FillType.Items.AddRange(new object[] {
            "Solid Fill",
            "Pattern Fill"});
            this.comboBox_FillType.Location = new System.Drawing.Point(759, 26);
            this.comboBox_FillType.Name = "comboBox_FillType";
            this.comboBox_FillType.Size = new System.Drawing.Size(121, 21);
            this.comboBox_FillType.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.comboBox_FillType);
            this.Controls.Add(this.btn_ParamSet);
            this.Controls.Add(this.comboBox_DashStyle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pencilSize);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mainDrawingPicture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Your Life";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pencilSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDrawingPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStrip_New;
        private System.Windows.Forms.ToolStripButton toolStrip_Open;
        private System.Windows.Forms.ToolStripButton toolStrip_Save;
        private System.Windows.Forms.ToolStripButton toolStrip_TextFont;
        private System.Windows.Forms.ToolStripButton toolStrip_ForeColor;
        private System.Windows.Forms.ToolStripLabel toolStrip_ColorText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.PictureBox mainDrawingPicture;
        private System.Windows.Forms.Button btn_Parabola;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Button btn_Hyperbola;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStrip_TextForeColor;
        private System.Windows.Forms.Label lb_positionMouse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Button btn_Eye;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListView listView_layer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_Layer;
        private System.Windows.Forms.Label lb_Mouse;
        private System.Windows.Forms.Button btn_pencilSize;
        private System.Windows.Forms.NumericUpDown pencilSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_DashStyle;
        private System.Windows.Forms.Button btn_Move;
        private System.Windows.Forms.Button btn_ParamSet;
        private System.Windows.Forms.Button btn_Scale;
        private System.Windows.Forms.Button btn_Rotate;
        private System.Windows.Forms.Button btn_Polygon;
        private System.Windows.Forms.ToolStripButton toolStrip_BackColor;
        private System.Windows.Forms.ToolStripTextBox toolStrip_TextBackColor;
        private System.Windows.Forms.Button btn_Bezier;
        private System.Windows.Forms.Button btn_TextTool;
        private System.Windows.Forms.Button btn_Selection;
        private System.Windows.Forms.Button btn_Zigzag;
        private System.Windows.Forms.ToolStripButton toolStrip_Undo;
        private System.Windows.Forms.ToolStripButton toolStrip_Redo;
        private System.Windows.Forms.ToolStripButton toolStrip_Copy;
        private System.Windows.Forms.ToolStripButton toolStrip_Cut;
        private System.Windows.Forms.ToolStripLabel toolStripLb_penSize;
        private System.Windows.Forms.ComboBox comboBox_FillType;
    }
}


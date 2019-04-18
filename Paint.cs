using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Paint
{
    partial class MainForm : Form
    {
        Bitmap mainDrawingBitmap;
        Graphics mainDrawingGraphics;

        PaintSpace paintParams = new PaintSpace();

        ColorManager colorManager = new ColorManager();
        FontDialog fontDlg = new FontDialog();

        ToolGenerator shapeToolGenerator = new ToolGenerator();
        Tool currentTool;
        string currentToolName;

        Counter counterShape = new Counter();

        Rectangle currentScreenSelection = new Rectangle();

        private int previousIndex = -1;
        private Stack<MySerializeObj> stackUndo;
        private Stack<MySerializeObj> stackRedo;

        public MainForm()
        {
            InitializeComponent();
            InitializeDashStyleComboBox();

            setForeColor(Color.Black);
            setBackColor(Color.Transparent);
            setDashStyle(DashStyle.Solid);
            setBorderWidth(1.0f);
            setFont(new Font(FontFamily.GenericSansSerif, 8));
            comboBox_FillType.Text = "Solid Fill";
        }

        private void InitializeDashStyleComboBox()
        {
            Dictionary<string, DashStyle> dictDashStyles = new Dictionary<string, DashStyle>
            {
                { "Solid",      DashStyle.Solid },
                { "Dash",       DashStyle.Dash },
                { "Dot",        DashStyle.Dot },
                { "DashDot",    DashStyle.DashDot },
                { "DashDotDot", DashStyle.DashDotDot },
                { "Custom",     DashStyle.Custom }
            };

            comboBox_DashStyle.DataSource = new BindingSource(dictDashStyles, null);
            comboBox_DashStyle.DisplayMember = "Key";
            comboBox_DashStyle.ValueMember = "Value";
        }

        private void setBorderWidth(float f)
        {
            paintParams.BorderWidth = f;
            pencilSize.Value = Convert.ToDecimal(f);
        }

        private void setDashStyle(DashStyle dashStyle)
        {
            comboBox_DashStyle.SelectedValue = dashStyle;
            paintParams.DashStyle = (int)dashStyle;
        }

        private void setBackColor(Color c)
        {
            if (c != Color.Transparent)
            {
                toolStrip_TextBackColor.ForeColor = colorManager.getValueColor(c);
                toolStrip_TextBackColor.BackColor = c;
            }
            else
            {
                toolStrip_TextBackColor.ForeColor = Color.Black;
                toolStrip_TextBackColor.BackColor = Color.White;
            }
            toolStrip_TextBackColor.Text = ColorTranslator.ToHtml(c).ToString();
            paintParams.BackColor = c;
        }

        private void setPattern(Bitmap bitmap)
        {
            paintParams.Pattern = bitmap;
        }

        private void setForeColor(Color c)
        {
            if (c != Color.Transparent)
            {
                toolStrip_TextForeColor.ForeColor = colorManager.getValueColor(c);
                toolStrip_TextForeColor.BackColor = c;
            }
            else
            {
                toolStrip_TextForeColor.ForeColor = Color.Black;
                toolStrip_TextForeColor.BackColor = Color.White;
            }
            toolStrip_TextForeColor.Text = ColorTranslator.ToHtml(c).ToString();
            paintParams.ForeColor = c;
        }

        private void setFont(Font f)
        {
            fontDlg.Font = f;
            paintParams.TextFont = f;
        }

        private void setSizePicture(int width, int height)
        {
            mainDrawingBitmap = new Bitmap(width, height);
            //mainDrawingPicture.Height = height;
            //mainDrawingPicture.Width = width;
        }

        private void createFirstLayer(int width, int height)
        {
            ListViewItem item = new ListViewItem("Item 1");
            item.Selected = true;

            Bitmap temp = new Bitmap(width, height);
            Layer layer = new Layer(temp);
            paintParams.MainGraphics = Graphics.FromImage(layer.getBitmap());
            paintParams.MainGraphics.Clear(Color.Transparent);
            item.Tag = layer;
            //item.Tag = temp;

            listView_layer.Items.Add(item);
            btn_Add.Enabled = true;
        }

        public void CreateMainPaint(int width, int height)
        {
            if (listView_layer.Items.Count > 0)
                deleteAllLayersBMP();

            setSizePicture(width, height);
            listView_layer.Clear();
            mainDrawingPicture.Enabled = true;

            //createFirstLayer(width, height);
            previousIndex = -1;
            btn_Add.Enabled = true;

            mainDrawingGraphics = Graphics.FromImage(mainDrawingBitmap);
            mainDrawingPicture.Image = mainDrawingBitmap;

            ReDraw();
            mainDrawingPicture.Show();

            currentTool = shapeToolGenerator.Generate("Line");
            currentToolName = "Line";

            stackUndo = new Stack<MySerializeObj>();
            stackRedo = new Stack<MySerializeObj>();

            counterShape = new Counter();
    }

        private void ShowVisibleLayers()
        {
            mainDrawingGraphics.Clear(Color.Transparent);
            for (int i = listView_layer.Items.Count - 1; i >= 0; i--)
            {
                Layer layer = (listView_layer.Items[i].Tag as Layer);
                if (!layer.IsHidden())
                {
                    //Layer layer = (listView_layer.Items[i].Tag as Layer);
                    layer.Render(mainDrawingGraphics); 
                }
            }

            for (int i = listView_layer.Items.Count - 1; i >= 0; i--)
            {
                Layer layer = (listView_layer.Items[i].Tag as Layer);
                if (layer.IsSelected())
                {
                    //Layer layer = (listView_layer.Items[i].Tag as Layer);
                    //layer.Render(mainDrawingGraphics);
                    layer.DrawBounds(mainDrawingGraphics);
                    break;
                }
            }
        }

        public void ReDraw()
        {
            ShowVisibleLayers();
            mainDrawingPicture.Refresh();
        }
       
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!mainDrawingPicture.Enabled)
            {
                NewForm newForm = new NewForm(this);
                newForm.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn tạo Layer mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    NewForm newForm = new NewForm(this);
                    newForm.ShowDialog();
                }
            }
        }

        private void toolStrip_New_Click(object sender, EventArgs e)
        {
            if (!mainDrawingPicture.Enabled)
            {
                NewForm newForm = new NewForm(this);
                newForm.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn tạo Layer mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    NewForm newForm = new NewForm(this);
                    newForm.ShowDialog();
                }
            }
        }

        private void mainDrawingPicture_MouseLeave(object sender, EventArgs e)
        {
            lb_Mouse.Text = "Mouse Position: No Mouse.";
        }

        private void mainDrawingPicture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && currentTool != null)
            {
                UndoStackPush();

                if (currentTool.Type() == PaintTool.TransformationTool)
                {
                    currentTool.onMouseDown(e, paintParams);
                }
                else if (currentTool.Type() == PaintTool.CDShapeTool)
                {
                    createNewShapeLayer();
                    currentTool.onMouseDown(e, paintParams);
                }
                else if (currentTool.Type() == PaintTool.SelectionTool)
                {
                    if (listView_layer.SelectedItems.Count > 0)
                    {
                        ListViewItem item = listView_layer.SelectedItems[0];
                        if (item.Tag.GetType() == typeof(ShapeLayer))
                        {
                            if (MessageBox.Show("You need to Rasterize this Layer before Selection. Are you sure?", "Rasterize", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                RasterizeCurrentLayer();
                            }
                        }
                        else
                        {
                            currentScreenSelection = new Rectangle();
                            currentTool.onMouseDown(e, paintParams);
                        }
                    }
                }
            }
        }

        private void mainDrawingPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentTool != null)
            {
                if (currentTool.Type() == PaintTool.MultiPointsTool)
                {
                    object shape = currentTool.onMouseDown(e, paintParams);
                    if (shape == null)
                    {
                        createNewShapeLayer();
                    }
                    else if (shape != null)
                    {
                        ShapeLayer layer = listView_layer.SelectedItems[0].Tag as ShapeLayer;
                        if (layer != null)
                        {
                            layer.setShape(shape as Shape);
                            ReDraw();
                        }
                    }
                }
                else if (currentTool.Type() == PaintTool.TextTool)
                {
                    createNewShapeLayer();
                    object shape = currentTool.onMouseDown(e, paintParams);
                    ShapeLayer layer = listView_layer.SelectedItems[0].Tag as ShapeLayer;
                    if (layer != null)
                    {
                        layer.setShape(shape as Shape);
                        ReDraw();
                    }
                }
            }
        }

        private void UndoStackPush()
        {
            stackUndo.Push(new MySerializeObj(this));
            stackRedo.Clear();
        }

        private void mainDrawingPicture_MouseMove(object sender, MouseEventArgs e)
        {
            lb_Mouse.Text = String.Format("Mouse Position: X: {0}; Y: {1}", e.X, e.Y);

            if (e.Button == MouseButtons.Left && currentTool != null)
            {
                if (currentTool.Type() == PaintTool.TransformationTool)
                {
                    Transformation currentShape = currentTool.onMouseMove(e, paintParams) as Transformation;
                    if (listView_layer.SelectedItems.Count > 0)
                    {
                        Layer layer = listView_layer.SelectedItems[0].Tag as Layer;
                        layer.Transform(currentShape);
                        ReDraw();
                        layer.ResetMatrix();
                    }
                }
                else if (currentTool.Type() == PaintTool.CDShapeTool)
                {
                    Shape currentShape = currentTool.onMouseMove(e, paintParams) as Shape;
                    ShapeLayer layer = listView_layer.SelectedItems[0].Tag as ShapeLayer;
                    layer.setShape(currentShape);
                    ReDraw();
                }
                else if (currentTool.Type() == PaintTool.SelectionTool)
                {
                    ShowVisibleLayers();
                    
                    MyRectangle currentShape = currentTool.onMouseMove(e, paintParams) as MyRectangle;
                    GraphicsPath path = currentShape.GetPath();

                    Pen pen = new Pen(Color.Black, 0.1f);
                    float[] dashStyle = new float[] { 2, 5, 10, 4 };
                    pen.DashPattern = dashStyle;

                    mainDrawingGraphics.DrawPath(pen, path);
                    mainDrawingPicture.Refresh();
                }
            }
        }

        private void mainDrawingPicture_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && currentTool != null)
            {
                if (currentTool.Type() == PaintTool.TransformationTool)
                {
                    Transformation newShape = currentTool.onMouseUp(e, paintParams) as Transformation;
                    Layer layer = listView_layer.SelectedItems[0].Tag as Layer;
                    layer.Transform(newShape, true);

                    ReDraw();
                }
                else if (currentTool.Type() == PaintTool.CDShapeTool)
                {
                    Shape newShape = currentTool.onMouseUp(e, paintParams) as Shape;
                    ShapeLayer layer = listView_layer.SelectedItems[0].Tag as ShapeLayer;
                    layer.setShape(newShape);

                    ReDraw();
                }
                else if (currentTool.Type() == PaintTool.SelectionTool)
                {
                    currentScreenSelection = (currentTool.onMouseUp(e, paintParams) as MyRectangle).ToRectangle();
                }
            }
        }

        private void toolStrip_Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                setForeColor(colorDialog.Color);
            }
        }

        private void btn_Tool_Click(object sender, EventArgs e)
        {
            currentToolName = (sender as Button).Tag.ToString();
            currentTool = shapeToolGenerator.Generate(currentToolName);
            currentTool.Reset();
        }

        private void listView_layer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_layer.SelectedIndices.Count > 0)
            {
                btn_Delete.Enabled = true;
                btn_Eye.Enabled = true;
                btn_Up.Enabled = true;
                btn_Down.Enabled = true;

                btn_Move.Enabled = true;
                btn_Scale.Enabled = true;
                btn_Rotate.Enabled = true;

                if (listView_layer.SelectedIndices[0] == 0)
                {
                    btn_Up.Enabled = false;
                }

                if (listView_layer.SelectedIndices[0] == listView_layer.Items.Count - 1)
                {
                    btn_Down.Enabled = false;
                }

                lb_Layer.Text = string.Format("Layer: {0}", listView_layer.SelectedItems[0].Text);

                if (previousIndex >= 0)
                {
                    Console.WriteLine(previousIndex);
                    Layer previousLayer = listView_layer.Items[previousIndex].Tag as Layer;
                    previousLayer.ChangeSelection(false);
                }

                Layer layer = listView_layer.SelectedItems[0].Tag as Layer;
                layer.ChangeSelection(true);
                previousIndex = listView_layer.SelectedIndices[0];
                PaintSpace ps = layer.GetParams();
                if (ps != null)
                    ResetParams(ps);
                ReDraw();
            }
            else
            {
                btn_Delete.Enabled = false;
                btn_Eye.Enabled = false;
                btn_Up.Enabled = false;
                btn_Down.Enabled = false;

                btn_Move.Enabled = false;
                btn_Scale.Enabled = false;
                btn_Rotate.Enabled = false;

                (listView_layer.Items[previousIndex].Tag as Layer).ChangeSelection(false);
                previousIndex = -1;
                ReDraw();
            }

            if (listView_layer.Items.Count == 1)
            {
                btn_Delete.Enabled = false;
                btn_Eye.Enabled = false;
            }
        }

        private void ResetParams(PaintSpace p)
        {
            setForeColor(p.ForeColor);
            setBackColor(p.BackColor);
            setDashStyle((DashStyle)p.DashStyle);
            setBorderWidth(p.BorderWidth);
            setFont(p.TextFont);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UndoStackPush();

            counterShape.Increase("Bitmap");
            string nameLayer = string.Format("{0} {1}", "Bitmap", counterShape.GetCount("Bitmap"));
            ListViewItem item = new ListViewItem(nameLayer);
            item.Selected = true;

            Bitmap bitmap = new Bitmap(mainDrawingPicture.Width, mainDrawingPicture.Height);
            Layer layer = new Layer(bitmap);
            layer.SetName(nameLayer);
            item.Tag = layer;
            
            listView_layer.Items.Insert(0, item);
            //ReDraw();
        }

        private void createNewShapeLayer()
        {
            counterShape.Increase(currentToolName);
            string nameLayer = string.Format("{0} {1}", currentToolName, counterShape.GetCount(currentToolName));
            ListViewItem item = new ListViewItem(nameLayer);
            item.Selected = true;

            Bitmap bitmap = new Bitmap(mainDrawingPicture.Width, mainDrawingPicture.Height);
            Layer layer = new ShapeLayer(bitmap);
            layer.SetName(nameLayer);
            ChangeLayerSelection(layer);

            item.Tag = layer;

            listView_layer.Items.Insert(0, item);

            //ReDraw();
        }

        private void ChangeLayerSelection(Layer layer)
        {
            if (previousIndex >= 0)
            {
                Console.WriteLine(previousIndex);
                Layer previousLayer = listView_layer.Items[previousIndex].Tag as Layer;
                previousLayer.ChangeSelection(false);
            }
            layer.ChangeSelection(true);
        }

        private void deleteAllLayersBMP()
        {
            mainDrawingBitmap.Dispose();
            foreach (ListViewItem item in listView_layer.Items)
            {
                Layer layer = item.Tag as Layer;
                using (Bitmap bmp = layer.getBitmap())
                {
                    bmp.Dispose();
                }
            }
        } 

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            UndoStackPush();

            Layer layer = listView_layer.SelectedItems[0].Tag as Layer;
            //using (Bitmap bmp = layer.getBitmap() as Bitmap)
            //{
                //bmp.Dispose();
            //}

            int selectedLayerId = listView_layer.SelectedItems[0].Index;
            if (selectedLayerId != listView_layer.Items.Count - 1)
            {
                listView_layer.Items[selectedLayerId + 1].Selected = true;
                //previousIndex = selectedLayerId + 1;
            }
            else
            {
                listView_layer.Items[selectedLayerId - 1].Selected = true;
                //previousIndex = selectedLayerId - 1;
            }
            listView_layer.Items.RemoveAt(selectedLayerId);

            (listView_layer.SelectedItems[0].Tag as Layer).ChangeSelection(true);
            previousIndex = listView_layer.SelectedIndices[0];

            if (listView_layer.Items.Count == 1)
            {
                btn_Delete.Enabled = false;
                btn_Eye.Enabled = false;
            }

            if (listView_layer.SelectedIndices[0] == 0)
            {
                btn_Up.Enabled = false;
            }

            if (listView_layer.SelectedIndices[0] == listView_layer.Items.Count - 1)
            {
                btn_Down.Enabled = false;
            }

            ReDraw();
        }

        private void btn_Eye_Click(object sender, EventArgs e)
        {
            (listView_layer.SelectedItems[0].Tag as Layer).ToggleState();
            ReDraw();
        }

        private void changePositionLayer(string position)
        {
            int id;
            if (position == "up")
                id = listView_layer.SelectedIndices[0] - 1;
            else
                id = listView_layer.SelectedIndices[0] + 1;

            ListViewItem temp = listView_layer.Items[id];

            listView_layer.Items[id] = listView_layer.SelectedItems[0].Clone() as ListViewItem;
            listView_layer.Items[listView_layer.SelectedIndices[0]] = temp;
            listView_layer.Items[id].Selected = true;
            ReDraw();
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            changePositionLayer("up");
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            changePositionLayer("down");
        }

        public void setPencilWidthValue(float value)
        {
            paintParams.BorderWidth = value;
        }

        private void pencilSize_ValueChanged(object sender, EventArgs e)
        {
            setBorderWidth((float)pencilSize.Value);
        }

        private void btn_pencilSize_Click(object sender, EventArgs e)
        {
            SetPencilWidth setWidth = new SetPencilWidth(this);
            setWidth.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DashStyle dashStyle = ((KeyValuePair<String, DashStyle>)comboBox_DashStyle.SelectedItem).Value;
            setDashStyle(dashStyle);
        }

        private void btn_ParamSet_Click(object sender, EventArgs e)
        {
            if (listView_layer.Items.Count > 0)
            {
                Layer selectedLayer = listView_layer.SelectedItems[0].Tag as Layer;
                selectedLayer.UpdateParams(paintParams);
                ReDraw();
            }
        }

        private void toolStrip_BackColor_Click(object sender, EventArgs e)
        {
            if (comboBox_FillType.Text == "Solid Fill")
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    setBackColor(colorDialog.Color);
                    setPattern(null);
                }
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                    if (bitmap == null || bitmap.Width == 0 || bitmap.Height == 0) throw new Exception();
                    setPattern(bitmap);
                }
            }
        }

        

        private void toolStrip_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PaintYourLife Files|*.pyl|Image Files|*.png; *.jpg; *.jpeg;...";

            if (mainDrawingPicture.Visible && saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (listView_layer.SelectedItems.Count > 0)
                    {
                        Layer layer = listView_layer.SelectedItems[0].Tag as Layer;
                        layer.ChangeSelection(false);
                    }

                    ReDraw();
                    string a = Path.GetExtension(saveDialog.FileName);
                    switch (a.ToLower())
                    {
                        case ".bmp":
                            mainDrawingBitmap.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        case ".png":
                            mainDrawingBitmap.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        case ".jpg":
                        case ".jpeg":
                            mainDrawingBitmap.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case ".gif":
                            mainDrawingBitmap.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                        case ".pyl":
                            IFormatter formatter = new BinaryFormatter();
                            Stream stream = new FileStream(saveDialog.FileName,
                                                     FileMode.Create,
                                                     FileAccess.Write, FileShare.None);
                            MySerializeObj obj = new MySerializeObj(this);
                            formatter.Serialize(stream, obj);

                            stream.Close();
                            break;
                        default: throw new Exception("Cannot save your life !!!");
                    }
                    MessageBox.Show("Saving your life successfully");
                }
                catch (Exception error) { MessageBox.Show(error.Message); }

            }
        }

        [Serializable]
        class MySerializeObj
        {
            int width;
            int height;
            Counter counter;
            List<Layer> layer;
            int previousIndex;

            public MySerializeObj(MainForm mainForm)
            {
                layer = new List<Layer>();
                foreach (ListViewItem item in mainForm.listView_layer.Items)
                {
                    layer.Add(item.Tag as Layer);
                }
                width = mainForm.mainDrawingPicture.Width;
                height = mainForm.mainDrawingPicture.Height;
                counter = mainForm.counterShape;
                previousIndex = mainForm.previousIndex;
            }

            public List<Layer> GetLayer()
            {
                return layer;
            }

            public Size GetSize()
            {
                return new Size(width, height);
            }

            public Counter GetCounter()
            {
                return counter;
            }

            public int GetPreviousIndex()
            {
                return previousIndex;
            }
        }

        private void OpenFile()
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "PaintYourLife Files|*.pyl|Image Files|*.png; *.jpg; *.jpeg;...";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openDialog.FileName).ToLower() == ".pyl")
                    OpenPYLFile(openDialog.FileName);
                else
                {
                    try
                    {
                        Bitmap bitmap = new Bitmap(openDialog.FileName);
                        if (bitmap == null || bitmap.Width == 0 || bitmap.Height == 0) throw new Exception();

                        if (bitmap.Width > 700 || bitmap.Height > 500)
                        {
                            float scale = Math.Min(700 * 1.0f / bitmap.Width, 500 * 1.0f / bitmap.Height);
                            bitmap = new Bitmap(bitmap, new Size((int)(bitmap.Width * scale), (int)(bitmap.Height * scale)));
                        }

                        CreateMainPaint(bitmap.Width, bitmap.Height);

                        counterShape.Increase("Bitmap");
                        string nameLayer = string.Format("{0} {1}", "Bitmap", counterShape.GetCount("Bitmap"));
                        ListViewItem item = new ListViewItem(nameLayer);
                        item.Selected = true;
                        Layer layer = new Layer(bitmap);
                        layer.SetName(nameLayer);
                        item.Tag = layer;
                        listView_layer.Items.Add(item);

                        btn_Add.Enabled = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot open your life !!!");
                    }
                }
            }
        }

        private void OpenPYLFile(string dir)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(dir,
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);

            MySerializeObj obj = formatter.Deserialize(stream) as MySerializeObj;
            LoadSerializedObj(obj);
            stream.Close();
        }

        private void LoadSerializedObj(MySerializeObj obj)
        {
            Size size = obj.GetSize();
            CreateMainPaint(size.Width, size.Height);
            LoadLayersFromSerializedObj(obj);
        }

        private void LoadLayersFromSerializedObj(MySerializeObj obj)
        {
            listView_layer.Clear();
            List<Layer> layer = obj.GetLayer();
            counterShape = obj.GetCounter();

            foreach (Layer l in layer)
            {
                ListViewItem item = new ListViewItem(l.GetName());
                item.Tag = l;
                listView_layer.Items.Add(item);
            }

            previousIndex = obj.GetPreviousIndex();

            ReDraw();
        }

        private void toolStrip_Open_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void toolStrip_TextFont_Click(object sender, EventArgs e)
        {
            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                setFont(fontDlg.Font);
            }
        }

        private void RasterizeCurrentLayer()
        {
            if (listView_layer.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_layer.SelectedItems[0];
                if (item.Tag.GetType() == typeof(ShapeLayer))
                {
                    Layer layer = item.Tag as Layer;
                    layer = layer.Rasterize();

                    counterShape.Increase("Bitmap");
                    string nameLayer = string.Format("{0} {1}", "Bitmap", counterShape.GetCount("Bitmap"));

                    layer.SetName(nameLayer);
                    item.Text = nameLayer;
                    item.Selected = true;
                    item.Tag = layer;

                    ReDraw();
                }
            }
        }

        private void btn_Rasterize_Click(object sender, EventArgs e)
        {
            RasterizeCurrentLayer();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (currentTool != null && currentTool.Type() == PaintTool.SelectionTool)
            {
                if (listView_layer.SelectedItems.Count > 0)
                {
                    if (e.KeyData == Keys.Delete)
                    {
                        UndoStackPush();

                        Console.WriteLine(currentScreenSelection);
                        Layer layer = listView_layer.SelectedItems[0].Tag as Layer;
                        layer.DeleteSelection(currentScreenSelection);
                        ReDraw();
                    }
                    else if (e.KeyData == (Keys.Control | Keys.C))
                    {
                        Copy();
                    }
                    else if (e.KeyData == (Keys.Control | Keys.X))
                    {
                        UndoStackPush();
                        Cut();
                    }
                }
            }

            if (mainDrawingPicture != null && mainDrawingPicture.Enabled == true)
            {
                if (e.KeyData == (Keys.Control | Keys.Z))
                {
                    Undo();
                }
                else if (e.KeyData == (Keys.Control | Keys.Y))
                {
                    Redo();
                }
            }
        }

        private void Copy()
        {
            Layer layer = listView_layer.SelectedItems[0].Tag as Layer;
            layer.CopySelection(currentScreenSelection);
        }

        private void Cut()
        {
            Layer layer = listView_layer.SelectedItems[0].Tag as Layer;
            layer.CopySelection(currentScreenSelection);
            layer.DeleteSelection(currentScreenSelection);
            ReDraw();
        }

        private void Redo()
        {
            if (stackRedo.Count > 0)
            {
                stackUndo.Push(new MySerializeObj(this));
                LoadLayersFromSerializedObj(stackRedo.Pop());
            }
        }

        private void Undo()
        {
            if (stackUndo.Count > 0)
            {
                stackRedo.Push(new MySerializeObj(this));
                LoadLayersFromSerializedObj(stackUndo.Pop());
            }
        }

        private void toolStrip_Undo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void toolStrip_Redo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void toolStrip_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void toolStrip_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }
    }
}

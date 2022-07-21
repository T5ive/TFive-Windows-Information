using TFive.Library.Automation.Detection.Finder;
using TFive.Library.Helper;
using TFive_Windows_Information.Properties;
using BorderStyle = System.Windows.Forms.BorderStyle;

namespace TFive_Windows_Information;

public partial class FrmMain : Form
{
    #region Variable

    private static Finder.CoordModes _coordMode;

    #endregion Variable

    public FrmMain()
    {
        InitializeComponent();
    }

    #region Load

    private void FrmMain_Load(object sender, EventArgs e)
    {
        LoadLocation();
        LoadSetting();
        LoadDataElement();
        LoadDataMain();
        finder1.SetOutput(UpdateInfo);
    }

    private void LoadLocation()
    {
        if (Settings.Default.Location == new Point(0, 0))
        {
            CenterToScreen();
        }
        else
        {
            Location = Settings.Default.Location;
        }
    }

    private void LoadSetting()
    {
        alwaysTopToolStripMenuItem.Checked = Settings.Default.AlwaysTop;
        magnifyToolStripMenuItem.Checked = Settings.Default.Magnify;
        showColorToolStripMenuItem.Checked = Settings.Default.ShowColor;
        CoordMode((Finder.CoordModes)Settings.Default.CoordMode);
    }

    #endregion Load

    #region Close

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        UpdateSetting(5);
    }

    #endregion Close

    #region Setting Utils

    private void UpdateSetting(int setting)
    {
        switch (setting)
        {
            case 0:
                Settings.Default.AlwaysTop = alwaysTopToolStripMenuItem.Checked;
                TopMost = alwaysTopToolStripMenuItem.Checked;
                break;

            case 1:
                Settings.Default.CoordMode = (int)_coordMode;
                break;

            case 2:
                Settings.Default.Magnify = magnifyToolStripMenuItem.Checked;
                finder1.Magnify = magnifyToolStripMenuItem.Checked;
                break;

            case 3:
                Settings.Default.ShowColor = showColorToolStripMenuItem.Checked;
                panelColor.BorderStyle = showColorToolStripMenuItem.Checked ? BorderStyle.FixedSingle : BorderStyle.None;
                if (!showColorToolStripMenuItem.Checked)
                {
                    panelColor.BackColor = default;
                }
                break;

            case 5: // All
                Settings.Default.AlwaysTop = alwaysTopToolStripMenuItem.Checked;
                Settings.Default.CoordMode = (int)_coordMode;
                Settings.Default.Magnify = magnifyToolStripMenuItem.Checked;
                Settings.Default.ShowColor = showColorToolStripMenuItem.Checked;
                Settings.Default.Location = Location;
                break;
        }
        Settings.Default.Save();
    }

    private void CoordMode(Finder.CoordModes coordMode)
    {
        switch (coordMode)
        {
            case Finder.CoordModes.Screen:
                screenToolStripMenuItem.Checked = true;
                windowToolStripMenuItem.Checked = false;
                _coordMode = Finder.CoordModes.Screen;
                break;

            case Finder.CoordModes.Window:
                windowToolStripMenuItem.Checked = true;
                screenToolStripMenuItem.Checked = false;
                _coordMode = Finder.CoordModes.Window;
                break;
        }

        finder1.SetCoordModes(coordMode);
        UpdateSetting(1);
    }

    #endregion Setting Utils

    #region Get Info

    private void UpdateInfo()
    {
        UpdateData(dataElement, Utils.DataType.Position, finder1.Detection.ElementPosition.ToPointString());
        UpdateData(dataElement, Utils.DataType.ColorHex, finder1.Detection.ElementColorHex);
        UpdateData(dataElement, Utils.DataType.ColorRGB, finder1.Detection.ElementColorRGB.ToRGB());
        UpdateData(dataElement, Utils.DataType.Size, finder1.Detection.ElementSize.ToSizeString());
        UpdateData(dataElement, Utils.DataType.Handle, finder1.Detection.ElementHandle.ToString());
        UpdateData(dataElement, Utils.DataType.HandleX, finder1.Detection.ElementHandleX);
        UpdateData(dataElement, Utils.DataType.Title, finder1.Detection.ElementTitle);
        UpdateData(dataElement, Utils.DataType.Class, finder1.Detection.ElementClass);

        UpdateData(dataMain, Utils.DataType.Position, finder1.Detection.WindowPosition.ToPointString());
        UpdateData(dataMain, Utils.DataType.ColorHex, finder1.Detection.WindowColorHex);
        UpdateData(dataMain, Utils.DataType.ColorRGB, finder1.Detection.WindowColorRGB.ToRGB());
        UpdateData(dataMain, Utils.DataType.Size, finder1.Detection.WindowSize.ToSizeString());
        UpdateData(dataMain, Utils.DataType.Handle, finder1.Detection.WindowHandle.ToString());
        UpdateData(dataMain, Utils.DataType.HandleX, finder1.Detection.WindowHandleX);
        UpdateData(dataMain, Utils.DataType.Title, finder1.Detection.WindowTitle);
        UpdateData(dataMain, Utils.DataType.Class, finder1.Detection.WindowClass);

        if (showColorToolStripMenuItem.Checked)
        {
            panelColor.BackColor = finder1.Detection.ElementColorRGB;
        }

        if (tabControl1.SelectedTab == tabElement)
        {
            txtTitle.Text = finder1.Detection.ElementTitle;
            txtClassName.Text = finder1.Detection.ElementClass;
        }
        else
        {
            txtTitle.Text = finder1.Detection.WindowTitle;
            txtClassName.Text = finder1.Detection.WindowClass;
        }
    }

    #endregion Get Info

    #region Menu

    private void screenToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CoordMode(Finder.CoordModes.Screen);
    }

    private void windowToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CoordMode(Finder.CoordModes.Window);
    }
    private void alwaysTopToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
        UpdateSetting(0);
    }

    private void magnifyToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
        UpdateSetting(2);
    }

    private void showColorToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
        UpdateSetting(3);
    }
    private void alwaysTopToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void magnifyToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void showColorToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    #endregion Menu

    #region Data Utils

    private void UpdateData(DataGridView dataList, Utils.DataType type, string value)
    {
        const int column = 1; // Value
        var row = (int)type;
        dataList[column, row].Value = value;
    }

    #endregion Data Utils

    #region Data List

    private void LoadDataElement()
    {
        dataElement.Rows.Add("Position", "");
        dataElement.Rows.Add("Color Hex", "");
        dataElement.Rows.Add("Color RGB", "");
        dataElement.Rows.Add("Size", "");

        dataElement.Rows.Add("Handle", "");
        dataElement.Rows.Add("Handle X", "");
        dataElement.Rows.Add("Title", "");
        dataElement.Rows.Add("Class", "");
    }

    private void LoadDataMain()
    {
        dataMain.Rows.Add("Position", "");
        dataMain.Rows.Add("Color Hex", "");
        dataMain.Rows.Add("Color RGB", "");
        dataMain.Rows.Add("Size", "");

        dataMain.Rows.Add("Handle", "");
        dataMain.Rows.Add("Handle X", "");
        dataMain.Rows.Add("Title", "");
        dataMain.Rows.Add("Class", "");
    }

    private void data_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right) return;
        var dataList = (DataGridView)sender;
        var hti = dataList.HitTest(e.X, e.Y);
        dataList.ClearSelection();
        dataList.Rows[hti.RowIndex].Selected = true;

        menuStrip1.Show();
    }

    private void data_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        CopyText(tabControl1.SelectedTab == tabElement ? dataElement : dataMain);
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CopyText(tabControl1.SelectedTab == tabElement ? dataElement : dataMain);
    }

    private static void CopyText(DataGridView data)
    {
        if (data.SelectedRows.Count == 0) return;
        Clipboard.SetText(data.SelectedRows[0].Cells[1].Value.ToString()!);
    }

    #endregion Data List


}
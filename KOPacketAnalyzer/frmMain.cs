using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KOPacketAnalyzer
{
    public enum DataTypes
    {
        Byte = 1,
        Int16 = 2,
        Int32 = 4,
        Int64 = 8,
        String
    }

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private List<Tuple<byte, string>> _byteBuffer = new List<Tuple<byte, string>>();

        private void txtPkt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtPkt.Text))
            {
                txtPkt.Text = txtPkt.Text.Trim().TrimStart().TrimEnd();
                ParsePacket();
            }
        }

        private void ParsePacket()
        {
            ConvertToByteArray();
            pktDetails.Items.Clear();
            var enumTry = Enum.GetNames(typeof(DataTypes));
            for (int i = 0; i < enumTry.Length; i++)
            {
                string keyType = enumTry[i].ToLower();
                if (chkAllowedTypes.CheckedItems.IndexOf(keyType) != -1)
                {
                    GetData(enumTry[i]);
                }
            }
        }

        private void GetData(string dataTypeName)
        {
            DataTypes parsedType = (DataTypes)Enum.Parse(typeof(DataTypes), dataTypeName);
            int amountToGet = (int)parsedType;
            for (int i = 0; i < _byteBuffer.Count; i++)
            {
                int maxGet = i + amountToGet;
                string hexRep = string.Empty;
                string valueRep = string.Empty;
                string textRep = string.Empty;
                IEnumerable<Tuple<byte, string>> innerBytes;
                if (maxGet <= _byteBuffer.Count)
                {
                    innerBytes = _byteBuffer.Skip(i).Take(amountToGet);
                    hexRep = string.Join(string.Empty, innerBytes.Select(x => x.Item2));
                }
                else return;

                switch (parsedType)
                {
                    case DataTypes.Byte:
                        textRep = Encoding.UTF8.GetString(new byte[] { _byteBuffer[i].Item1 });
                        valueRep = $"{_byteBuffer[i].Item1.ToString()}";
                        hexRep = _byteBuffer[i].Item2;
                        break;
                    case DataTypes.Int16:
                        valueRep = BitConverter.ToUInt16(innerBytes.Select(x => x.Item1).ToArray(), 0).ToString();
                        break;
                    case DataTypes.Int32:
                        valueRep = BitConverter.ToUInt32(innerBytes.Select(x => x.Item1).ToArray(), 0).ToString();
                        break;
                    case DataTypes.Int64:
                        valueRep = BitConverter.ToUInt64(innerBytes.Select(x => x.Item1).ToArray(), 0).ToString();
                        break;
                    default:
                        return;
                }

                pktDetails.Items.Add(CreateListViewItem(dataTypeName, $"{(i + 1)}, {maxGet}", hexRep, valueRep, textRep));
            }
        }

        private void ConvertToByteArray()
        {
            _byteBuffer.Clear();
            int currentIndex = 0;
            if (chkSkipOpcode.Checked) currentIndex += 2;
            if (chkSkipSubOpCode.Checked) currentIndex += 2;
            for (; currentIndex < txtPkt.TextLength; currentIndex += 2)
            {
                string hex = new string(txtPkt.Text.Skip(currentIndex).Take(2).ToArray());
                _byteBuffer.Add(new Tuple<byte, string>(Convert.ToByte(hex, 16), hex));
            }
        }

        private ListViewItem CreateListViewItem(params string[] members)
        {
            var listViewItem = new ListViewItem
            {
                Name = members[0]
            };

            if (members.Length > 0)
            {
                listViewItem.Text = members[0];
                for (int i = 1; i < members.Length; i++)
                {
                    listViewItem.SubItems.Add(members[i]);
                }
            }

            return listViewItem;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < chkAllowedTypes.Items.Count; i++)
            {
                chkAllowedTypes.SetItemChecked(i, true);
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            ParsePacket();
        }

        private void chkAllowedTypes_KeyDown(object sender, KeyEventArgs e)
        {
            ParsePacket();
        }

        private void pktDetails_DoubleClick(object sender, EventArgs e)
        {
            Point localPoint = pktDetails.PointToClient(Cursor.Position);
            ListViewHitTestInfo hitTest = pktDetails.HitTest(localPoint);
            if (hitTest != null)
            {
                int columnIndex = hitTest.Item.SubItems.IndexOf(hitTest.SubItem);
                if (columnIndex != -1
                    && columnIndex != 0
                    && columnIndex != 1)
                {
                    ListViewItem.ListViewSubItem foundItem = pktDetails.GetItemAt(localPoint.X, localPoint.Y).SubItems[columnIndex];
                    if (foundItem != null && !string.IsNullOrEmpty(foundItem.Text))
                    {
                        Clipboard.SetText(foundItem.Text);
                        lblState.ForeColor = Color.ForestGreen;
                        lblState.Text = $"State: Copied {foundItem.Text} !";

                        if (chkBeep.Checked)
                        {
                            Console.Beep();
                        }
                    }
                }
            }
        }

        private void chkSkipOpcode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSkipOpcode.Checked)
            {
                chkSkipSubOpCode.Enabled = true;
            }
            else
            {
                chkSkipSubOpCode.Enabled = false;
                chkSkipSubOpCode.Checked = false;
            }
        }
    }
}

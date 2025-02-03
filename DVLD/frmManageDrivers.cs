using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLVD_Project
{
    public partial class frmManageDrivers : Form
    {
        DataTable dtAllDrivers;
        public frmManageDrivers()
        {
            InitializeComponent();
        }
        private enum FilterMode
        {
              None = 0
            , DriverID = 1
            , NationalNo = 2
            , FullName = 3
            , NumberOfActiveLicenses = 4
        };
        private FilterMode _filterType = FilterMode.None;

        private FilterMode _ChangeFillterType()
        {
            _LoadData();
            tbFilter.Visible = true;

            switch (cbfilterType.SelectedIndex)
            {
                case 0:
                    tbFilter.Visible = false;
                    return FilterMode.None;
                case 1:
                    return FilterMode.DriverID;
                case 2:
                    return FilterMode.NationalNo;
                case 3:
                    return FilterMode.FullName;
                case 4:
                    return FilterMode.NumberOfActiveLicenses;
                default:
                    tbFilter.Visible = false;
                    return FilterMode.None;
            }
        }

        private DataView _Filter(string filterValue)
        {
            dtAllDrivers = clsDrivers.GetAllDrivers();
            DataView dvAllDrivers = new DataView(dtAllDrivers);

            switch (_filterType)
            {
                case FilterMode.DriverID:
                    if (int.TryParse(filterValue, out int insertID))
                        dvAllDrivers.RowFilter = $"DriverID = {insertID}";
                    break;
                case FilterMode.NationalNo:
                    dvAllDrivers.RowFilter = $"NationalNo LIKE '{filterValue}%'";
                    break;
                case FilterMode.FullName:
                    dvAllDrivers.RowFilter = $"FullName LIKE '{filterValue}%'";
                    break;
                case FilterMode.NumberOfActiveLicenses:
                    if (int.TryParse(filterValue, out int insertNumber))
                        dvAllDrivers.RowFilter = $"NumberOfActiveLicenses = {insertNumber}";
                    break;
            }
            return dvAllDrivers;
        }

        private void _LoadData(string filterValue = "") 
        {
            dgvDrivers.DataSource = _Filter(filterValue);
            lbResultRecordsNum.Text = dgvDrivers.RowCount.ToString();
            
        }
        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void cbfilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filterType = _ChangeFillterType();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            cbfilterType.SelectedIndex = 0;
            _filterType = _ChangeFillterType();

            _LoadData(tbFilter.Text);
        }
    }
}

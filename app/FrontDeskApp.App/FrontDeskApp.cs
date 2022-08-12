using FrontDeskApp.App.Services;
using FrontDeskApp.Common.Models;
using Newtonsoft.Json;

namespace FrontDeskApp.App;

public partial class FrontDeskApp : Form
{
    private IFrontDeskApiClient _apiClient;

    public FrontDeskApp(IFrontDeskApiClient apiClient)
    {
        _apiClient = apiClient;

        InitializeComponent();
        InitializeFields();
        InitializeEvents();
    }

    private async void InitializeFields()
    {
        ShowCustomerDataFields();
        HideFacilityDataFields();
        HideRecordDataFields();

        clearButton.Show();
    }
    private async void InitializeEvents()
    {
        btn1.Click += btn1_Click;
        btn2.Click += btn2_Click;
        btn3.Click += btn3_Click;
        clearButton.Click += clearButton_Click;

        dataGridView1.CellClick += dataGridView1_CellContentClick;

        cCreateBtn.Click += cCreateBtn_Click;
        cUpdateButton.Click += cUpdateButton_Click;

        rCreateButton.Click += rCreateButton_Click;
        rReserveButton.Click += rReserveButton_Click;
        rCancelButton.Click += rCancelButton_Click;
        rStoreButton.Click += rStoreButton_Click;
        rRetrieveButton.Click += rRetrieveButton_Click;

        rCustomerIdValue.TextChanged += rCustomerIdValue_TextChanged;
        rFacilityIdValue.TextChanged += rFacilityIdValue_TextChanged;

        rBoxTypeValue.DataSource = new List<string>() { "Small", "Medium", "Large" };
    }

    private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        var index = e.RowIndex;
        if (index >= 0)
        {
            var row = dataGridView1.Rows[index];

            if (String.Equals(title.Text, "Customer"))
            {
                var id = row.Cells["Id"].Value.ToString();
                cIdValue.Text = id;
                cFirstNameValue.Text = row.Cells["FirstName"].Value.ToString();
                cLastNameValue.Text = row.Cells["LastName"].Value.ToString();
                cPhoneNumberValue.Text = row.Cells["PhoneNumber"].Value.ToString();
                cDataValue.Text = row.Cells["Data"].Value.ToString();

                cCreateBtn.Hide();
                cUpdateButton.Show();
            }

            else if (String.Equals(title.Text, "Facility"))
            {
                var id = row.Cells["Id"].Value.ToString();
                fIdValue.Text = id;
                fNameValue.Text = row.Cells["Name"].Value.ToString();

                var facility = await _apiClient.GetFacility(Int32.Parse(id));
                string data = "Capacity:";
                foreach(var info in facility.FacilityStorageInfo)
                {
                    data += "\n\r\t" + $"-- {info.BoxType}: {info.Capacity}";
                }

                fDataValue.Text = data;
            }


            else if (String.Equals(title.Text, "Record"))
            {
                var id = row.Cells["Id"].Value.ToString();
                rIdValue.Text = id;
                rCustomerIdValue.Text = row.Cells["CustomerId"].Value.ToString();
                rCustomerNameValue.Text = row.Cells["CustomerName"].Value.ToString();
                rFacilityIdValue.Text = row.Cells["FacilityId"].Value.ToString();
                rFacilityNameValue.Text = row.Cells["FacilityName"].Value.ToString();
                rBoxTypeValue.Text = row.Cells["BoxType"].Value.ToString();
                var status = row.Cells["Status"].Value.ToString();

                rCustomerIdValue.Enabled = false;
                rFacilityIdValue.Enabled = false;
                rBoxTypeValue.Enabled = false;

                rCreateButton.Hide();
                rReserveButton.Hide();
                rStoreButton.Hide();
                rRetrieveButton.Hide();
                rCancelButton.Hide();

                switch(status)
                {
                    case "New":
                    {
                        rReserveButton.Show();
                        rStoreButton.Show();
                        break;
                    }
                    case "Reserved":
                    {
                            rCancelButton.Show();
                            rStoreButton.Show();
                            break;
                    }
                    case "Stored":
                    {
                            rRetrieveButton.Show();
                            break;
                    }
                }
            }
        }
        else
        {
            clearData();
        }
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
        clearData();
    }
    private async void btn1_Click(object sender, EventArgs e)
    {
        HideRecordDataFields();
        HideFacilityDataFields();
        ShowCustomerDataFields();
        await GetCustomerData();
    }
    private async void btn2_Click(object sender, EventArgs e)
    {
        HideCustomerDataFields();
        HideRecordDataFields();
        ShowFacilityDataFields();
        await GetFacilitiesData();
    }
    private async void btn3_Click(object sender, EventArgs e)
    {
        HideCustomerDataFields();
        HideFacilityDataFields();
        ShowRecordDataFields();
        await GetRecordData();
    }

    private async void cCreateBtn_Click(object sender, EventArgs e) 
    {
        //add Error Check
        if (String.IsNullOrWhiteSpace(cFirstNameValue.Text)
            || String.IsNullOrWhiteSpace(cLastNameValue.Text)
            || String.IsNullOrWhiteSpace(cPhoneNumberValue.Text)
        )
        {
            System.Windows.Forms.MessageBox.Show("Please make sure all fields are valid.", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            var customer = new Customer()
            {
                FirstName = cFirstNameValue.Text,
                LastName = cLastNameValue.Text,
                PhoneNumber = cPhoneNumberValue.Text,
                Data = cDataValue.Text
            };
            await _apiClient.CreateCustomer(customer);
            await GetCustomerData();

            System.Windows.Forms.MessageBox.Show("Successfully created customer.", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    private async void cUpdateButton_Click(object sender, EventArgs e) 
    {
        if (String.IsNullOrWhiteSpace(cIdValue.Text)
            || String.IsNullOrWhiteSpace(cFirstNameValue.Text)
            || String.IsNullOrWhiteSpace(cLastNameValue.Text)
            || String.IsNullOrWhiteSpace(cPhoneNumberValue.Text)
        )
        {
            System.Windows.Forms.MessageBox.Show("Please make sure all fields are valid.", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            var customer = new Customer()
            {
                Id = Int32.Parse(cIdValue.Text),
                FirstName = cFirstNameValue.Text,
                LastName = cLastNameValue.Text,
                PhoneNumber = cPhoneNumberValue.Text,
                Data = cDataValue.Text
            };
            await _apiClient.UpdateCustomer(customer);
            await GetCustomerData();

            System.Windows.Forms.MessageBox.Show("Successfully updated customer.", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private async void rCreateButton_Click(object sender, EventArgs e) 
    {
        //add Error Check
        if(rCustomerNameValue.Text.StartsWith("ERROR") 
            || rCustomerNameValue.Text.StartsWith(" --")
            || rFacilityNameValue.Text.StartsWith("ERROR")
            || rFacilityNameValue.Text.StartsWith(" --")
        )
        {
            System.Windows.Forms.MessageBox.Show("Please make sure all fields are valid.", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            var customerViewModel = await _apiClient.GetCustomer(Int32.Parse(rCustomerIdValue.Text));
            var facilityViewModel = await _apiClient.GetFacility(Int32.Parse(rFacilityIdValue.Text));
            var record = new Record()
            {
                Id = 0,
                CustomerId = Int32.Parse(rCustomerIdValue.Text),
                Customer = new Customer()
                {
                    Id = customerViewModel.Id,
                    FirstName = customerViewModel.FirstName,
                    LastName = customerViewModel.LastName,
                    PhoneNumber = customerViewModel.PhoneNumber,
                    Data = JsonConvert.SerializeObject(customerViewModel.Data)
                },
                FacilityId = Int32.Parse(rFacilityIdValue.Text),
                Facility = new Facility()
                {
                    Id = facilityViewModel.Id,
                    Name = facilityViewModel.Name,
                    FacilityStorageInfo = facilityViewModel.FacilityStorageInfo.ToList()
                },
                BoxType = Enum.Parse<BoxType>(rBoxTypeValue.Text),
                Status = Status.New,
                CreatedOnUtc = DateTime.UtcNow,
                StoredOnUtc = null,
                RetrievedOnUtc = null,
                Data = "{}"
            };
            await _apiClient.CreateRecord(record);
            await GetRecordData();

            System.Windows.Forms.MessageBox.Show("Successfully created record.", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    private async void rReserveButton_Click(object sender, EventArgs e) {
        UpdateRecord(Status.Reserved);
    }
    private async void rCancelButton_Click(object sender, EventArgs e) {
        UpdateRecord(Status.Cancelled);
    }
    private async void rStoreButton_Click(object sender, EventArgs e) {
        UpdateRecord(Status.Stored);
    }
    private async void rRetrieveButton_Click(object sender, EventArgs e) {
        UpdateRecord(Status.Retrieved);
    }

    private async void rCustomerIdValue_TextChanged(object sender, EventArgs e)
    {
        Int32.TryParse(rCustomerIdValue.Text, out var customerId);
        if(customerId != default(int))
        {
            var customer = await _apiClient.GetCustomer(customerId);
            rCustomerNameValue.Text = $"{customer.FirstName} {customer.LastName}";
        }
        else
        {
            rCustomerNameValue.Text = "ERROR: No customer found for id. Please input a correct customer id.";
        }
    }
    private async void rFacilityIdValue_TextChanged(object sender, EventArgs e) 
    {
        Int32.TryParse(rFacilityIdValue.Text, out var facilityId);
        if (facilityId != default(int))
        {
            var facility = await _apiClient.GetFacility(facilityId);
            rFacilityNameValue.Text = $"{facility.Name}";
        }
        else
        {
            rFacilityNameValue.Text = "ERROR: No facility found for id. Please input a correct facility id.";
        }
    }

    private void ShowRecordDataFields()
    {
        title.Text = "Record";
        clearButton.Show();
        rCreateButton.Show();

        rId.Show();
        rIdValue.Show();

        rCustomerId.Show();
        rCustomerIdValue.Show();
        rCustomerName.Show();
        rCustomerNameValue.Show();

        rFacilityId.Show();
        rFacilityIdValue.Show();
        rFacilityName.Show();
        rFacilityNameValue.Show();

        rBoxType.Show();
        rBoxTypeValue.Show();
    }
    private void HideRecordDataFields()
    {
        rCreateButton.Hide();
        rReserveButton.Hide();
        rStoreButton.Hide();
        rRetrieveButton.Hide();
        rCancelButton.Hide();

        rId.Hide();
        rIdValue.Hide();

        rCustomerId.Hide();
        rCustomerIdValue.Hide();
        rCustomerName.Hide();
        rCustomerNameValue.Hide();

        rFacilityId.Hide();
        rFacilityIdValue.Hide();
        rFacilityName.Hide();
        rFacilityNameValue.Hide();

        rBoxType.Hide();
        rBoxTypeValue.Hide();
    }
    private void ShowFacilityDataFields()
    {
        title.Text = "Facility";
        fId.Show();
        fIdValue.Show();

        fName.Show();
        fNameValue.Show();

        fDataValue.Show();
    }
    private void HideFacilityDataFields()
    {
        fId.Hide();
        fIdValue.Hide();

        fName.Hide();
        fNameValue.Hide();

        fDataValue.Hide();
    }
    private void ShowCustomerDataFields(bool isUpdate = false)
    {
        title.Text = "Customer";
        cCreateBtn.Show();
        cUpdateButton.Hide();

        cId.Show();
        cIdValue.Show();
        cData.Show();
        cDataValue.Show();
        cFirstName.Show();
        cFirstNameValue.Show();
        cLastName.Show();
        cLastNameValue.Show();
        cPhoneNumber.Show();
        cPhoneNumberValue.Show();

        if (isUpdate)
        {
            cUpdateButton.Show();
            cCreateBtn.Hide();
        }

        clearButton.Show();
    }
    private void HideCustomerDataFields()
    {
        cCreateBtn.Hide();
        cUpdateButton.Hide();
        clearButton.Hide();

        cId.Hide();
        cIdValue.Hide();
        cData.Hide();
        cDataValue.Hide();
        cFirstName.Hide();
        cFirstNameValue.Hide();
        cLastName.Hide();
        cLastNameValue.Hide();
        cPhoneNumber.Hide();
        cPhoneNumberValue.Hide();
    }

    private void clearData()
    {
        if (String.Equals(title.Text, "Customer"))
        {
            cIdValue.Text = "--";
            cFirstNameValue.Text = "";
            cLastNameValue.Text = "";
            cPhoneNumberValue.Text = "";
            cDataValue.Text = "{}";

            cCreateBtn.Show();
            cUpdateButton.Hide();
        }
        else if (String.Equals(title.Text, "Record"))
        {
            rCustomerIdValue.Text = "";
            rCustomerNameValue.Text = "--";

            rFacilityIdValue.Text = "";
            rFacilityNameValue.Text = "--";

            rCreateButton.Show();
            rReserveButton.Hide();
            rStoreButton.Hide();
            rRetrieveButton.Hide();

            rIdValue.Text = "--";

            rBoxTypeValue.Enabled = true;
            rCustomerIdValue.Enabled = true;
            rFacilityIdValue.Enabled = true;
        }
    }

    private async Task GetCustomerData()
    {
        var customers = await _apiClient.GetCustomers();
        dataGridView1.DataSource = customers;
    }
    private async Task GetFacilitiesData()
    {
        var facilities = await _apiClient.GetFacilities();
        dataGridView1.DataSource = facilities;
    }
    private async Task GetRecordData()
    {
        var records = await _apiClient.GetRecords();
        dataGridView1.DataSource = records;
    }

    private async void UpdateRecord(Status status)
    {
        var id = Int32.Parse(rIdValue.Text);
        var customerViewModel = await _apiClient.GetCustomer(Int32.Parse(rCustomerIdValue.Text));
        var facilityViewModel = await _apiClient.GetFacility(Int32.Parse(rFacilityIdValue.Text));
        var record = new Record()
        {
            Id = id,
            CustomerId = customerViewModel.Id,
            Customer = new Customer()
            {
                Id = customerViewModel.Id,
                FirstName = customerViewModel.FirstName,
                LastName = customerViewModel.LastName,
                PhoneNumber = customerViewModel.PhoneNumber,
                Data = JsonConvert.SerializeObject(customerViewModel.Data)
            },
            FacilityId = facilityViewModel.Id,
            Facility = new Facility()
            {
                Id = facilityViewModel.Id,
                Name = facilityViewModel.Name,
                FacilityStorageInfo = facilityViewModel.FacilityStorageInfo.ToList()
            },
            BoxType = Enum.Parse<BoxType>(rBoxTypeValue.Text),
            Status = Status.New,
            CreatedOnUtc = DateTime.UtcNow,
            StoredOnUtc = null,
            RetrievedOnUtc = null,
            Data = "{}"
        };

        switch (status)
        {
            case Status.Reserved:
                {
                    record.Status = Status.Reserved;
                    break;
                }
            case Status.Stored:
                {
                    record.Status = Status.Stored;
                    record.StoredOnUtc = DateTime.UtcNow;
                    break;
                }
            case Status.Retrieved:
                {
                    record.Status = Status.Retrieved;
                    record.RetrievedOnUtc = DateTime.UtcNow;
                    break;
                }
            case Status.Cancelled:
                {
                    record.Status = Status.Cancelled;
                    break;
                }
        }
        await _apiClient.UpdateRecord(record);
        await GetRecordData();
        clearData();

        System.Windows.Forms.MessageBox.Show("Successfully updated record.", "Success",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

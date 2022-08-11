using FrontDeskApp.App.Services;

namespace FrontDeskApp.App;

public partial class FrontDeskApp : Form
{
    private IFrontDeskApiClient _apiClient;

    public FrontDeskApp(IFrontDeskApiClient apiClient)
    {
        _apiClient = apiClient;

        InitializeComponent();
        btn1.Click += btn1_Click;
        btn2.Click += btn2_Click;
        btn3.Click += btn3_Click;
    }

    private async Task GetCustomerData(){
        var customers = await _apiClient.GetCustomers();
        dataGridView1.DataSource = customers;
    }

    private async Task GetFacilitiesData(){
        var facilities = await _apiClient.GetFacilities();
        dataGridView1.DataSource = facilities;
    }

    private async Task GetRecordData(){
        var records = await _apiClient.GetRecords();
        dataGridView1.DataSource = records;
    }

    private async void btn1_Click(object sender, EventArgs e)
    {
        await GetCustomerData();
    }

    private async void btn2_Click(object sender, EventArgs e)
    {
        await GetFacilitiesData();
    }

    private async void btn3_Click(object sender, EventArgs e)
    {
        await GetRecordData();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }
}

namespace FrontDeskApp.App;

partial class FrontDeskApp
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cCreateBtn = new System.Windows.Forms.Button();
            this.cUpdateButton = new System.Windows.Forms.Button();
            this.cId = new System.Windows.Forms.Label();
            this.cLastNameValue = new System.Windows.Forms.TextBox();
            this.cIdValue = new System.Windows.Forms.Label();
            this.cLastName = new System.Windows.Forms.Label();
            this.cFirstName = new System.Windows.Forms.Label();
            this.cFirstNameValue = new System.Windows.Forms.TextBox();
            this.cPhoneNumber = new System.Windows.Forms.Label();
            this.cPhoneNumberValue = new System.Windows.Forms.TextBox();
            this.cData = new System.Windows.Forms.Label();
            this.cDataValue = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.fId = new System.Windows.Forms.Label();
            this.fIdValue = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.fNameValue = new System.Windows.Forms.Label();
            this.fDataValue = new System.Windows.Forms.Label();
            this.rFacilityNameValue = new System.Windows.Forms.Label();
            this.rFacilityName = new System.Windows.Forms.Label();
            this.rFacilityIdValue = new System.Windows.Forms.TextBox();
            this.rFacilityId = new System.Windows.Forms.Label();
            this.rCustomerNameValue = new System.Windows.Forms.Label();
            this.rCustomerName = new System.Windows.Forms.Label();
            this.rCustomerIdValue = new System.Windows.Forms.TextBox();
            this.rCustomerId = new System.Windows.Forms.Label();
            this.rIdValue = new System.Windows.Forms.Label();
            this.rId = new System.Windows.Forms.Label();
            this.rCreateButton = new System.Windows.Forms.Button();
            this.rReserveButton = new System.Windows.Forms.Button();
            this.rStoreButton = new System.Windows.Forms.Button();
            this.rRetrieveButton = new System.Windows.Forms.Button();
            this.rCancelButton = new System.Windows.Forms.Button();
            this.rBoxType = new System.Windows.Forms.Label();
            this.rBoxTypeValue = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(20, 20);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 50);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Customers";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(20, 80);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 50);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Facilities";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(20, 140);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(150, 50);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(186, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(586, 170);
            this.dataGridView1.TabIndex = 3;
            // 
            // cCreateBtn
            // 
            this.cCreateBtn.Location = new System.Drawing.Point(634, 393);
            this.cCreateBtn.Name = "cCreateBtn";
            this.cCreateBtn.Size = new System.Drawing.Size(138, 45);
            this.cCreateBtn.TabIndex = 4;
            this.cCreateBtn.Text = "Create";
            this.cCreateBtn.UseVisualStyleBackColor = true;
            // 
            // cUpdateButton
            // 
            this.cUpdateButton.Location = new System.Drawing.Point(634, 393);
            this.cUpdateButton.Name = "cUpdateButton";
            this.cUpdateButton.Size = new System.Drawing.Size(138, 45);
            this.cUpdateButton.TabIndex = 5;
            this.cUpdateButton.Text = "Update";
            this.cUpdateButton.UseVisualStyleBackColor = true;
            // 
            // cId
            // 
            this.cId.AutoSize = true;
            this.cId.Location = new System.Drawing.Point(115, 261);
            this.cId.Name = "cId";
            this.cId.Size = new System.Drawing.Size(29, 20);
            this.cId.TabIndex = 6;
            this.cId.Text = "Id: ";
            // 
            // cLastNameValue
            // 
            this.cLastNameValue.Location = new System.Drawing.Point(150, 292);
            this.cLastNameValue.Name = "cLastNameValue";
            this.cLastNameValue.Size = new System.Drawing.Size(241, 27);
            this.cLastNameValue.TabIndex = 7;
            // 
            // cIdValue
            // 
            this.cIdValue.AutoSize = true;
            this.cIdValue.Location = new System.Drawing.Point(150, 261);
            this.cIdValue.Name = "cIdValue";
            this.cIdValue.Size = new System.Drawing.Size(25, 20);
            this.cIdValue.TabIndex = 8;
            this.cIdValue.Text = " --";
            // 
            // cLastName
            // 
            this.cLastName.AutoSize = true;
            this.cLastName.Location = new System.Drawing.Point(58, 295);
            this.cLastName.Name = "cLastName";
            this.cLastName.Size = new System.Drawing.Size(86, 20);
            this.cLastName.TabIndex = 9;
            this.cLastName.Text = "Last Name: ";
            // 
            // cFirstName
            // 
            this.cFirstName.AutoSize = true;
            this.cFirstName.Location = new System.Drawing.Point(58, 328);
            this.cFirstName.Name = "cFirstName";
            this.cFirstName.Size = new System.Drawing.Size(87, 20);
            this.cFirstName.TabIndex = 11;
            this.cFirstName.Text = "First Name: ";
            // 
            // cFirstNameValue
            // 
            this.cFirstNameValue.Location = new System.Drawing.Point(150, 325);
            this.cFirstNameValue.Name = "cFirstNameValue";
            this.cFirstNameValue.Size = new System.Drawing.Size(241, 27);
            this.cFirstNameValue.TabIndex = 10;
            // 
            // cPhoneNumber
            // 
            this.cPhoneNumber.AutoSize = true;
            this.cPhoneNumber.Location = new System.Drawing.Point(30, 361);
            this.cPhoneNumber.Name = "cPhoneNumber";
            this.cPhoneNumber.Size = new System.Drawing.Size(115, 20);
            this.cPhoneNumber.TabIndex = 13;
            this.cPhoneNumber.Text = "Phone Number: ";
            // 
            // cPhoneNumberValue
            // 
            this.cPhoneNumberValue.Location = new System.Drawing.Point(150, 358);
            this.cPhoneNumberValue.Name = "cPhoneNumberValue";
            this.cPhoneNumberValue.Size = new System.Drawing.Size(242, 27);
            this.cPhoneNumberValue.TabIndex = 12;
            // 
            // cData
            // 
            this.cData.AutoSize = true;
            this.cData.Location = new System.Drawing.Point(415, 292);
            this.cData.Name = "cData";
            this.cData.Size = new System.Drawing.Size(48, 20);
            this.cData.TabIndex = 14;
            this.cData.Text = "Data: ";
            // 
            // cDataValue
            // 
            this.cDataValue.Location = new System.Drawing.Point(469, 292);
            this.cDataValue.Name = "cDataValue";
            this.cDataValue.Size = new System.Drawing.Size(303, 27);
            this.cDataValue.TabIndex = 15;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(37, 393);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(138, 45);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(30, 234);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(77, 20);
            this.title.TabIndex = 17;
            this.title.Text = "Customer";
            // 
            // fId
            // 
            this.fId.AutoSize = true;
            this.fId.Location = new System.Drawing.Point(115, 261);
            this.fId.Name = "fId";
            this.fId.Size = new System.Drawing.Size(29, 20);
            this.fId.TabIndex = 18;
            this.fId.Text = "Id: ";
            // 
            // fIdValue
            // 
            this.fIdValue.AutoSize = true;
            this.fIdValue.Location = new System.Drawing.Point(145, 261);
            this.fIdValue.Name = "fIdValue";
            this.fIdValue.Size = new System.Drawing.Size(25, 20);
            this.fIdValue.TabIndex = 19;
            this.fIdValue.Text = " --";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Location = new System.Drawing.Point(92, 295);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(52, 20);
            this.fName.TabIndex = 20;
            this.fName.Text = "Name:";
            // 
            // fNameValue
            // 
            this.fNameValue.AutoSize = true;
            this.fNameValue.Location = new System.Drawing.Point(150, 295);
            this.fNameValue.Name = "fNameValue";
            this.fNameValue.Size = new System.Drawing.Size(25, 20);
            this.fNameValue.TabIndex = 21;
            this.fNameValue.Text = " --";
            // 
            // fDataValue
            // 
            this.fDataValue.AutoSize = true;
            this.fDataValue.Location = new System.Drawing.Point(469, 261);
            this.fDataValue.MinimumSize = new System.Drawing.Size(305, 110);
            this.fDataValue.Name = "fDataValue";
            this.fDataValue.Size = new System.Drawing.Size(305, 110);
            this.fDataValue.TabIndex = 22;
            this.fDataValue.Text = "Capacity:";
            // 
            // rFacilityNameValue
            // 
            this.rFacilityNameValue.AutoSize = true;
            this.rFacilityNameValue.Location = new System.Drawing.Point(518, 328);
            this.rFacilityNameValue.Name = "rFacilityNameValue";
            this.rFacilityNameValue.Size = new System.Drawing.Size(25, 20);
            this.rFacilityNameValue.TabIndex = 34;
            this.rFacilityNameValue.Text = " --";
            // 
            // rFacilityName
            // 
            this.rFacilityName.AutoSize = true;
            this.rFacilityName.Location = new System.Drawing.Point(405, 328);
            this.rFacilityName.Name = "rFacilityName";
            this.rFacilityName.Size = new System.Drawing.Size(101, 20);
            this.rFacilityName.TabIndex = 33;
            this.rFacilityName.Text = "Facility Name:";
            // 
            // rFacilityIdValue
            // 
            this.rFacilityIdValue.Location = new System.Drawing.Point(518, 292);
            this.rFacilityIdValue.Name = "rFacilityIdValue";
            this.rFacilityIdValue.Size = new System.Drawing.Size(254, 27);
            this.rFacilityIdValue.TabIndex = 32;
            // 
            // rFacilityId
            // 
            this.rFacilityId.AutoSize = true;
            this.rFacilityId.Location = new System.Drawing.Point(434, 295);
            this.rFacilityId.Name = "rFacilityId";
            this.rFacilityId.Size = new System.Drawing.Size(78, 20);
            this.rFacilityId.TabIndex = 31;
            this.rFacilityId.Text = "Facility Id: ";
            // 
            // rCustomerNameValue
            // 
            this.rCustomerNameValue.AutoSize = true;
            this.rCustomerNameValue.Location = new System.Drawing.Point(150, 328);
            this.rCustomerNameValue.Name = "rCustomerNameValue";
            this.rCustomerNameValue.Size = new System.Drawing.Size(25, 20);
            this.rCustomerNameValue.TabIndex = 38;
            this.rCustomerNameValue.Text = " --";
            // 
            // rCustomerName
            // 
            this.rCustomerName.AutoSize = true;
            this.rCustomerName.Location = new System.Drawing.Point(25, 328);
            this.rCustomerName.Name = "rCustomerName";
            this.rCustomerName.Size = new System.Drawing.Size(119, 20);
            this.rCustomerName.TabIndex = 37;
            this.rCustomerName.Text = "Customer Name:";
            // 
            // rCustomerIdValue
            // 
            this.rCustomerIdValue.Location = new System.Drawing.Point(150, 292);
            this.rCustomerIdValue.Name = "rCustomerIdValue";
            this.rCustomerIdValue.Size = new System.Drawing.Size(241, 27);
            this.rCustomerIdValue.TabIndex = 36;
            // 
            // rCustomerId
            // 
            this.rCustomerId.AutoSize = true;
            this.rCustomerId.Location = new System.Drawing.Point(49, 295);
            this.rCustomerId.Name = "rCustomerId";
            this.rCustomerId.Size = new System.Drawing.Size(96, 20);
            this.rCustomerId.TabIndex = 35;
            this.rCustomerId.Text = "Customer Id: ";
            // 
            // rIdValue
            // 
            this.rIdValue.AutoSize = true;
            this.rIdValue.Location = new System.Drawing.Point(146, 261);
            this.rIdValue.Name = "rIdValue";
            this.rIdValue.Size = new System.Drawing.Size(25, 20);
            this.rIdValue.TabIndex = 40;
            this.rIdValue.Text = " --";
            // 
            // rId
            // 
            this.rId.AutoSize = true;
            this.rId.Location = new System.Drawing.Point(116, 261);
            this.rId.Name = "rId";
            this.rId.Size = new System.Drawing.Size(29, 20);
            this.rId.TabIndex = 39;
            this.rId.Text = "Id: ";
            // 
            // rCreateButton
            // 
            this.rCreateButton.Location = new System.Drawing.Point(634, 393);
            this.rCreateButton.Name = "rCreateButton";
            this.rCreateButton.Size = new System.Drawing.Size(138, 45);
            this.rCreateButton.TabIndex = 41;
            this.rCreateButton.Text = "Create";
            this.rCreateButton.UseVisualStyleBackColor = true;
            // 
            // rReserveButton
            // 
            this.rReserveButton.Location = new System.Drawing.Point(469, 393);
            this.rReserveButton.Name = "rReserveButton";
            this.rReserveButton.Size = new System.Drawing.Size(138, 45);
            this.rReserveButton.TabIndex = 42;
            this.rReserveButton.Text = "Reserve";
            this.rReserveButton.UseVisualStyleBackColor = true;
            // 
            // rStoreButton
            // 
            this.rStoreButton.Location = new System.Drawing.Point(634, 393);
            this.rStoreButton.Name = "rStoreButton";
            this.rStoreButton.Size = new System.Drawing.Size(138, 45);
            this.rStoreButton.TabIndex = 43;
            this.rStoreButton.Text = "Store";
            this.rStoreButton.UseVisualStyleBackColor = true;
            // 
            // rRetrieveButton
            // 
            this.rRetrieveButton.Location = new System.Drawing.Point(635, 393);
            this.rRetrieveButton.Name = "rRetrieveButton";
            this.rRetrieveButton.Size = new System.Drawing.Size(138, 45);
            this.rRetrieveButton.TabIndex = 44;
            this.rRetrieveButton.Text = "Retrieve";
            this.rRetrieveButton.UseVisualStyleBackColor = true;
            // 
            // rCancelButton
            // 
            this.rCancelButton.Location = new System.Drawing.Point(469, 393);
            this.rCancelButton.Name = "rCancelButton";
            this.rCancelButton.Size = new System.Drawing.Size(138, 45);
            this.rCancelButton.TabIndex = 45;
            this.rCancelButton.Text = "Cancel";
            this.rCancelButton.UseVisualStyleBackColor = true;
            // 
            // rBoxType
            // 
            this.rBoxType.AutoSize = true;
            this.rBoxType.Location = new System.Drawing.Point(434, 261);
            this.rBoxType.Name = "rBoxType";
            this.rBoxType.Size = new System.Drawing.Size(72, 20);
            this.rBoxType.TabIndex = 46;
            this.rBoxType.Text = "Box Type:";
            // 
            // rBoxTypeValue
            // 
            this.rBoxTypeValue.FormattingEnabled = true;
            this.rBoxTypeValue.Location = new System.Drawing.Point(518, 258);
            this.rBoxTypeValue.Name = "rBoxTypeValue";
            this.rBoxTypeValue.Size = new System.Drawing.Size(151, 28);
            this.rBoxTypeValue.TabIndex = 47;
            // 
            // FrontDeskApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rBoxTypeValue);
            this.Controls.Add(this.rBoxType);
            this.Controls.Add(this.rCancelButton);
            this.Controls.Add(this.rRetrieveButton);
            this.Controls.Add(this.rStoreButton);
            this.Controls.Add(this.rReserveButton);
            this.Controls.Add(this.rCreateButton);
            this.Controls.Add(this.rIdValue);
            this.Controls.Add(this.rId);
            this.Controls.Add(this.rCustomerNameValue);
            this.Controls.Add(this.rCustomerName);
            this.Controls.Add(this.rCustomerIdValue);
            this.Controls.Add(this.rCustomerId);
            this.Controls.Add(this.rFacilityNameValue);
            this.Controls.Add(this.rFacilityName);
            this.Controls.Add(this.rFacilityIdValue);
            this.Controls.Add(this.rFacilityId);
            this.Controls.Add(this.fDataValue);
            this.Controls.Add(this.fNameValue);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.fIdValue);
            this.Controls.Add(this.fId);
            this.Controls.Add(this.title);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.cDataValue);
            this.Controls.Add(this.cData);
            this.Controls.Add(this.cPhoneNumber);
            this.Controls.Add(this.cPhoneNumberValue);
            this.Controls.Add(this.cFirstName);
            this.Controls.Add(this.cFirstNameValue);
            this.Controls.Add(this.cLastName);
            this.Controls.Add(this.cIdValue);
            this.Controls.Add(this.cLastNameValue);
            this.Controls.Add(this.cId);
            this.Controls.Add(this.cUpdateButton);
            this.Controls.Add(this.cCreateBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Name = "FrontDeskApp";
            this.Text = "FrontDeskApp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private Button btn1;
    private Button btn2;
    private Button btn3;

    #endregion

    private DataGridView dataGridView1;
    private Button cCreateBtn;
    private Button cUpdateButton;
    private Label cId;
    private TextBox cLastNameValue;
    private Label cIdValue;
    private Label cLastName;
    private Label cFirstName;
    private TextBox cFirstNameValue;
    private Label cPhoneNumber;
    private TextBox cPhoneNumberValue;
    private Label cData;
    private TextBox cDataValue;
    private Button clearButton;
    private Label title;
    private Label fId;
    private Label fIdValue;
    private Label fName;
    private Label fNameValue;
    private Label fDataValue;
    private Label rFacilityNameValue;
    private Label rFacilityName;
    private TextBox rFacilityIdValue;
    private Label rFacilityId;
    private Label rCustomerNameValue;
    private Label rCustomerName;
    private TextBox rCustomerIdValue;
    private Label rCustomerId;
    private Label rIdValue;
    private Label rId;
    private Button rCreateButton;
    private Button rReserveButton;
    private Button rStoreButton;
    private Button rRetrieveButton;
    private Button rCancelButton;
    private Label rBoxType;
    private ComboBox rBoxTypeValue;
}

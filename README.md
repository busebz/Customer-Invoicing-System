<h1>Customer Invoicing Application</h1>
<p>This is a customer invoicing application developed using <strong>C# Windows Forms</strong> and <strong>SQL Server</strong>. The application allows <strong>admins</strong> to manage customer information, handle invoice items (add, update, delete), and export invoices to Excel. It also supports foreign currency and local currency calculations for accurate invoicing.</p>

<h2>Features</h2>
<ul>
    <li><strong>Customer Information</strong>: Retrieve customer details from the database using a customer code.</li>
    <li><strong>Invoice Management</strong>: Admins can add, update, delete, and manage invoice items.</li>
    <li><strong>Excel Export</strong>: Export invoice data to an Excel file for record-keeping or further processing.</li>
    <li><strong>Currency Calculations</strong>: Supports both foreign currency and local currency invoicing for global transactions.</li>
</ul>

<h2>Requirements</h2>
<p>Before running the application, ensure the following are installed:</p>
<ul>
    <li><strong>Visual Studio</strong> (C# support).</li>
    <li><strong>SQL Server</strong> (Local or remote).</li>
</ul>

<h2>Project Structure</h2>
<ul>
    <li><strong>Backend</strong>: Contains the SQL script for setting up the database.</li>
    <li><strong>Frontend</strong>: Contains the Windows Forms application code.</li>
    <li><strong>Screenshots</strong>: Screenshots of the application’s user interface.</li>
</ul>

<h2>Setting Up the Project</h2>

<h3>1. Setup the Database</h3>
<p>In the <strong>Backend</strong> folder, you'll find the SQL script file.</p>
<p>Run the SQL script on your SQL Server to create the necessary database and tables.</p>

<h3>2. Modify the app.config File</h3>
<p>After setting up the database, you'll need to configure the connection string in the <strong>app.config</strong> file:</p>
<ul>
    <li>Open the <strong>app.config</strong> file located in the <strong>Frontend</strong> folder.</li>
    <li>Find the line that contains the <strong>Data Source</strong> value in the <strong>connectionString</strong> section.</li>
</ul>

<pre>
<code>
&lt;add name="MyDbConnection" connectionString="Data Source=[ServerName];Initial Catalog=InvoiceForm;Integrated Security=True;" providerName="System.Data.SqlClient" /&gt;
</code>
</pre>

<p>Replace <strong>[ServerName]</strong> with your SQL Server's name or IP address. For example:</p>
<ul>
    <li>Data Source=localhost; if you're using a local SQL Server instance.</li>
    <li>Data Source=YOUR_SERVER_NAME; if you're connecting to a remote server.</li>
</ul>

<h3>3. Run the Application</h3>
<ul>
    <li>Open the <strong>Frontend</strong> folder in Visual Studio.</li>
    <li>Build and run the project.</li>
</ul>

<p>You should now be able to use the application to manage invoices, customer data, and perform administrative tasks such as adding, updating, and deleting invoices.</p>

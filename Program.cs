namespace CashierQueuing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
            cashierWindow.Show();
            ServingForm servingForm = new ServingForm();
            servingForm.Show();

            Application.Run(new QueuingForm());
            Application.Run(servingForm);
        }
    }
}
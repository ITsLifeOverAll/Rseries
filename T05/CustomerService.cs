namespace T05;

public class CustomerService(CustomerRepository repository)
{
    public void RegisterCustomer(string name, string email)
    {
        if (!email.Contains("@"))
        {
            throw new ArgumentException("Invalid email");
        }

        var customer = new Customer(name, email);
        repository.Save(customer);

        SendWelcomeEmail(email);
    }

    public void UpdateCustomerEmail(int customerId, string newEmail)
    {
        var customer = repository.GetById(customerId);
        customer.Email = newEmail;
        repository.Save(customer);

        NotifyEmailChanged(customer);
    }

    private void SendWelcomeEmail(string email)
    {
        // 寄出 email 的實作...
    }

    private void NotifyEmailChanged(Customer customer)
    {
        // 發送通知的實作...
    }
}

//
// --- 以下為支援用的輔助程式碼，非本範例重點 ---
//

public class Customer
{
    public string Name;
    public string Email;

    public Customer(string name, string email)
    {
        Name = name;
        Email = email;
    }
}

public class CustomerRepository : ICustomerRepository
{
    public void Save(Customer customer)
    {
        throw new NotImplementedException();
    }

    public Customer GetById(int customerId)
    {
        throw new NotImplementedException();
    }
}

public interface ICustomerRepository
{
    void Save(Customer customer);
    Customer GetById(int customerId);
}



namespace ShopEase.Models
{
    public class StaffDashboardViewModel
    {
        public Staff Staff { get; set; }
        public IEnumerable<CustomerRequest> Requests { get; set; }

        // Additional property to count requests for better display 
        public int PendingRequestsCount => Requests.Count(r => r.RequestStatus == "Pending");
        public int InProgressRequestsCount => Requests.Count(r => r.RequestStatus == "InProgress");
        public int UnassignedRequestsCount => Requests.Count(r => r.StaffID == null);
    }
}

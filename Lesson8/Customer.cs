namespace Lesson8
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public long Code { get; set; }

        public Address CustomerAddress { get; set; }

        public CommonCard[] Cards { get; set; }

        public Customer(string firstName, string lastName, long code, Address customerAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Code = code;
            CustomerAddress = customerAddress;
            Cards = new CommonCard[0];
        }

        public void AddCard(CommonCard card)
        {
            CommonCard[] newCardArray = new CommonCard[Cards.Length + 1];
            for (int i = 0; i < Cards.Length; i++)
            {
                newCardArray[i] = Cards[i];
            }
            newCardArray[Cards.Length] = card;
            Cards = newCardArray;
        }

        public void AddCards(CommonCard[] newCards)
        {
            CommonCard[] newCardArray = new CommonCard[Cards.Length + newCards.Length];
            for (int i = 0; i < Cards.Length; i++)
            {
                newCardArray[i] = Cards[i];
            }
            for (int i = 0; i < newCards.Length; i++)
            {
                newCardArray[Cards.Length + i] = newCards[i];
            }
            Cards = newCardArray;
        }
    }
}

using System.Linq;

namespace Proje_2
{
    public class BoardManager
    {
        public void Add(Card card)
        {
            InMemoryBoard.Cards.Add(card);
        }
        public void Delete(Card card)
        {
            InMemoryBoard.Cards.Remove(card);
        }
        public Card GetCardByHeader(string header)
        {
           return InMemoryBoard.Cards.FirstOrDefault(card => card.Header == header);
        }
        public void Update(int value,string header)
        {
            var result = this.GetCardByHeader(header);
            Delete(result);
            result.State = (State)value;
            Add(result);
            
        }
    }

}

public static class CSEN
{
    public class Shop
    {
        public class Offers
        {

            /// <summary>
            /// Parse a CSEN string to a C# Object.
            /// </summary>
            /// <param name="csen">CSharpEasyNotation string.</param>
            /// <returns>A offers object Array.</returns>
            public Offers[] Parse(string csen, int max)
            {
                Offers[] offers = new Offers[max];
                string[] items = csen.Replace("\n", "").Split(';');
                int counter = 0;
                foreach (string item in items)
                {
                    string[] sections = item.Split('|');
                    string gettedOffer = sections[0];
                    string[] tuple = sections[1].Replace("(", "").Replace(")", "").Split(',');
                    string gettedItem = tuple[0];
                    int gettedPrice = int.Parse(tuple[1]);
                    string gettedTime = tuple[2];
                    offers[counter].item = gettedItem;
                    offers[counter].offer = gettedOffer;
                    offers[counter].price = gettedPrice;
                    offers[counter].time = gettedTime;
                    counter = counter + 1;
                }
                return offers;
            }

            // CSharpEasyNotationSchema (CSENS)
            /// <summary>
            /// Name (ID of the offer) no spaces
            /// Format: <c>"default-skin"</c> or <c>"special-offer_01"</c>
            /// </summary>
            public string offer;
            /// <summary>
            /// Item for offer
            /// Format: <c>"skin:cowgirl"</c> or <c>"powerup:speed"</c>
            /// </summary>
            public string item;
            /// <summary>
            /// Price in Coins
            /// Format: <c>100</c> or <c>10000</c>
            /// </summary>
            public int price;
            /// <summary>
            /// Time for offer (only for displaying)
            /// Format: <c>"ever"</c> or <c>"2020-07-10::16-16"</c>
            /// </summary>
            public string time;
        }
    }
}

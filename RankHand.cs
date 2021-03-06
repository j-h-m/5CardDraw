﻿namespace WindowsFormsApplication1
{
    public struct HandTotal
    {
        public int hTotal { get; set; }
    }

    internal class RankHand
    {
        public HandTotal HandSum;
        public int ClubsCount;     //rank of club suit = 1
        public int DiamondsCount;  //rank of diamond suit = 2
        public int HeartsCount; //rank of heart suit = 3
        public int SpadesCount;  //rank of spade suit = 4

        public HandTotal HandGetSet
        {
            get { return HandSum; }
            set { HandSum = value; }
        }

        public int evalHand(Card[] handCards)
        {
            ClubsCount = 0;
            DiamondsCount = 0;
            HeartsCount = 0;
            SpadesCount = 0;

            foreach (var item in handCards)
            {
                if (item.getSuit() == 1)
                {
                    ClubsCount++;
                }
                else if (item.getSuit() == 2)
                {
                    DiamondsCount++;
                }
                else if (item.getSuit() == 3)
                {
                    HeartsCount++;
                }
                else if (item.getSuit() == 4)
                {
                    SpadesCount++;
                }
            }
            //Straight Flush
            if (ClubsCount == 5)
            {
                if ((handCards[0].getFace() + 10 == handCards[1].getFace() && handCards[0].getFace() + 20 == handCards[2].getFace() && handCards[0].getFace() + 30 == handCards[3].getFace()) && (handCards[0].getFace() + 40 == handCards[4].getFace()))
                {
                    HandSum.hTotal = 8000 + (handCards[4].getFace()) + 1;
                    return HandSum.hTotal;
                }
            }
            else if (DiamondsCount == 5)
            {
                if ((handCards[0].getFace() + 10 == handCards[1].getFace() && handCards[0].getFace() + 20 == handCards[2].getFace() && handCards[0].getFace() + 30 == handCards[3].getFace()) && (handCards[0].getFace() + 40 == handCards[4].getFace()))
                {
                    HandSum.hTotal = 8000 + (handCards[4].getFace()) + 2;
                    return HandSum.hTotal;
                }
            }
            else if (HeartsCount == 5)
            {
                if ((handCards[0].getFace() + 10 == handCards[1].getFace() && handCards[0].getFace() + 20 == handCards[2].getFace() && handCards[0].getFace() + 30 == handCards[3].getFace()) && (handCards[0].getFace() + 40 == handCards[4].getFace()))
                {
                    HandSum.hTotal = 8000 + (handCards[4].getFace()) + 3;
                    return HandSum.hTotal;
                }
            }
            else if (SpadesCount == 5)
            {
                if ((handCards[0].getFace() + 10 == handCards[1].getFace() && handCards[0].getFace() + 20 == handCards[2].getFace() && handCards[0].getFace() + 30 == handCards[3].getFace()) && (handCards[0].getFace() + 40 == handCards[4].getFace()))
                {
                    HandSum.hTotal = 8000 + (handCards[4].getFace()) + 4;
                    return HandSum.hTotal;
                }
            }
            //Straight Flush

            //Four Of A Kind
            if (handCards[0].getFace() == handCards[1].getFace() && handCards[0].getFace() == handCards[2].getFace() && handCards[0].getFace() == handCards[3].getFace())
            {
                HandSum.hTotal = 7000 + (int)handCards[0].getFace() + (int)handCards[1].getFace() + (int)handCards[2].getFace() + (int)handCards[3].getFace();
                return HandSum.hTotal;
            }
            else if (handCards[1].getFace() == handCards[2].getFace() && handCards[1].getFace() == handCards[3].getFace() && handCards[1].getFace() == handCards[4].getFace())
            {
                HandSum.hTotal = 7000 + handCards[1].getFace() + (int)handCards[2].getFace() + (int)handCards[3].getFace() + (int)handCards[4].getFace();
                return HandSum.hTotal;
            }
            //Four Of A Kind

            //Full House

            if ((handCards[0].getFace() == handCards[1].getFace() && handCards[0].getFace() == handCards[2].getFace() && handCards[3].getFace() == handCards[4].getFace()))
            {
                HandSum.hTotal = 6000 + (handCards[0].getFace()) + (handCards[1].getFace()) + (handCards[2].getFace());
                return HandSum.hTotal;
            }
            else if (handCards[0].getFace() == handCards[1].getFace() && handCards[2].getFace() == handCards[3].getFace() && handCards[2].getFace() == handCards[4].getFace())
            {
                HandSum.hTotal = 6000 + (handCards[2].getFace()) + (handCards[3].getFace()) + (handCards[4].getFace());  //6000
                return HandSum.hTotal;
            }

            //Full House

            //Flush
            if (ClubsCount == 5)
            {
                HandSum.hTotal = 5000 + (handCards[4].getFace()) + 1;
                return HandSum.hTotal;
            }
            else if (DiamondsCount == 5)
            {
                HandSum.hTotal = 5000 + (handCards[4].getFace()) + 2;
                return HandSum.hTotal;
            }
            else if (HeartsCount == 5)
            {
                HandSum.hTotal = 5000 + (handCards[4].getFace()) + 3;
                return HandSum.hTotal;
            }
            else if (SpadesCount == 5)
            {
                HandSum.hTotal = 5000 + (handCards[4].getFace()) + 4;
                return HandSum.hTotal;
            }
            //Flush

            //Straight
            if ((handCards[0].getFace() + 10 == handCards[1].getFace() && handCards[0].getFace() + 20 == handCards[2].getFace() && handCards[0].getFace() + 30 == handCards[3].getFace()) && (handCards[0].getFace() + 40 == handCards[4].getFace()))
            {
                HandSum.hTotal = 4000 + (handCards[4].getFace()) + (handCards[4].getSuit());
                return HandSum.hTotal;
            }
            //Straight

            //Three Of A Kind
            if ((handCards[0].getFace() == handCards[1].getFace() && handCards[0].getFace() == handCards[2].getFace()))
            {
                HandSum.hTotal = 3000 + (handCards[0].getFace()) + (handCards[1].getFace()) + (handCards[2].getFace());
                return HandSum.hTotal;
            }
            else if ((handCards[1].getFace() == handCards[2].getFace() && handCards[1].getFace() == handCards[3].getFace()))
            {
                HandSum.hTotal = 3000 + (handCards[1].getFace()) + (handCards[2].getFace()) + (handCards[3].getFace());
                return HandSum.hTotal;
            }
            else if ((handCards[2].getFace() == handCards[3].getFace() && handCards[2].getFace() == handCards[4].getFace()))
            {
                HandSum.hTotal = 3000 + (handCards[2].getFace()) + (handCards[3].getFace()) + (handCards[4].getFace());
                return HandSum.hTotal;
            }
            //Three Of A Kind

            //Two Pairs
            if ((handCards[0].getFace() == handCards[1].getFace() && handCards[2].getFace() == handCards[3].getFace()))
            {
                HandSum.hTotal = 2000 + (handCards[3].getFace()) + (handCards[2].getFace()) + (handCards[4].getFace()) + (handCards[4].getSuit());
                return HandSum.hTotal;
            }
            else if ((handCards[0].getFace() == handCards[1].getFace() && handCards[3].getFace() == handCards[4].getFace()))
            {
                HandSum.hTotal = 2000 + (handCards[4].getFace()) + (handCards[3].getFace()) + (handCards[2].getFace()) + (handCards[2].getSuit());
                return HandSum.hTotal;
            }
            else if ((handCards[1].getFace() == handCards[2].getFace() && handCards[3].getFace() == handCards[4].getFace()))
            {
                HandSum.hTotal = 2000 + (handCards[4].getFace()) + (handCards[3].getFace()) + (handCards[0].getFace()) + handCards[0].getSuit();
                return HandSum.hTotal;
            }
            //Two Pairs

            //One Pair
            if (handCards[0].getFace() == handCards[1].getFace())
            {
                HandSum.hTotal = 1000 + (handCards[0].getFace()) + (handCards[1].getFace()) + (handCards[4].getFace()) + (handCards[4].getSuit());
                return HandSum.hTotal;
            }
            else if (handCards[1].getFace() == handCards[2].getFace())
            {
                HandSum.hTotal = 1000 + (handCards[1].getFace()) + (handCards[2].getFace()) + (handCards[4].getFace()) + handCards[4].getSuit();
                return HandSum.hTotal;
            }
            else if (handCards[2].getFace() == handCards[3].getFace())
            {
                HandSum.hTotal = 1000 + (handCards[2].getFace()) + (handCards[3].getFace()) + (handCards[4].getFace()) + (handCards[4].getSuit());
                return HandSum.hTotal;
            }
            else if (handCards[3].getFace() == handCards[4].getFace())
            {
                HandSum.hTotal = 1000 + (handCards[3].getFace()) + (handCards[4].getFace()) + (handCards[2].getFace()) + handCards[2].getSuit();
                return HandSum.hTotal;
            }
            //One Pair

            //High Card
            else
            {
                HandSum.hTotal = handCards[4].getFace() + handCards[4].getSuit();
                return HandSum.hTotal;
            }
            //High Card
        }
    }
}
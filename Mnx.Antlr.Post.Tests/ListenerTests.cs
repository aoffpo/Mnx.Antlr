using System;
using Antlr4.Runtime;
using Mnx.Antlr.Post.Grammars;
using Mnx.Antlr.Post.Listeners;
using NUnit.Framework;
using Mnx.Antlr.Post.Listeners.Models;

namespace Mnx.Antlr.Post.Tests
{
    [TestFixture]
    public class ListenerTests
    { 
        readonly DateTime[] _dates = new DateTime[2];
       // DateTime _now = new DateTime(2014, 5, 5, 12, 0, 0);
        DateTime _today = new DateTime(2014, 5, 5, 0, 0, 0);
        readonly PostData _postData = new PostData() { Timestamp = new DateTime(2014, 5, 5, 12, 0, 0) };
        DefaultListener _listener;
        Post_en_Parser _parser;
        [SetUp]
        public void Setup()
        {

        }
        private void Parse(string input)
        {
            var stream = new AntlrInputStream(input); //not IDisposable
            ITokenSource lexer = new Post_en_Lexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);//not IDisposable
            _parser = _parser ?? new Post_en_Parser(tokens);
            _listener = _listener ?? new DefaultListener();
            if (!_parser.ParseListeners.Contains(_listener))
            {
                _parser.AddParseListener(_listener);
            }
            _parser.statement();
        }
        [Test]
        public void TestDateFormatA()
        {
            //XXX START HERE XXX//
            string data = "Lunch is at 3000 Centre Green Way, Cary. Serving from 11:30-1:30 today!";
            Parse(data);
            var date1 = _listener.Data.StartDate;
            var date2 = _listener.Data.EndDate;
            Assert.IsTrue(date1 == _today.AddHours(11).AddMinutes(30), "Assertion 1a:" + data);
            Assert.IsTrue(date2 == _today.AddHours(13).AddMinutes(30), "Assertion 1b:" + data); //needs to be pm...

            data = "Serving Now at Duke by the Chapel  - Chapel Drive  Durham  Until 9:00 PM EST http://t.co/zVSQr9KWqr";
            Parse(data);
            data = "Come help us christen the bar Sip! @sipwinetweet at 1059 Darrington Dr, Cary, tonight from " +
                   "6-9ish.... http://t.co/tRt48MvJTj";
            Parse(data);
            data = "Lunch today were at Leith Porsche,Audi,Jag at the Cary Auto 11:30-2!";
            Parse(data);
            data = "We have TWO carts out today! One at @ganyardhillfarm 319 Sherron Rd, Durham  one at " +
                   "@DorcasCary 187 High House Rd. Cary 11AM-until";
            Parse(data);
            data = "Tonight, we will be at Sub Noir Brewing Company in Raleigh from 6 til..";
            Parse(data);
            data = "We will set at Qualcomm today in Raleigh with @Traditionssweet! We will be at 8041 Arco Corporate Drive until 1:30!";
            Parse(data);
            data = "Today, Better catch us #FAST at  OVAL PARK ^_^ 5:00pm – 6:30 210 West Club Blvd, Durham";
            Parse(data);
            data = "Join us for lunch today 2510 Meridian parkway in Durham.  11:30-1:30. Dinner at The Point Apartments in Chapel Hill. 5-8pm";
            Parse(data);
            //KoKyu ONDO Tonight on Rigsbee &amp; Geer in Downtown #Durham - 
            //
            //@Fullsteam Cackalacky Tempura Fish TaKo (or... http://t.co/AzmRM7y8T0

            //#BigYellow @ChirbaChirba Dinner!!!
            //Duke U west quad TONIGHT!
            //from 5-9
            //CC: @dukeunion @DukeLDOC @DukePerformance @DukeU @DukeU_NrsngSchl
        }
        [Ignore]
        [Test]
        public void TestDateFormatB()
        {
            var data = "We are all setup at Keystone Tech Park, Building 1. Serving till 1:30. 523 Davis Dr, RTP, NC http://t.co/j6cNCqMKwe";
          
            var date1 = _dates[0];
            var date2 = _dates[1];
            Assert.IsTrue(date1 == _postData.Timestamp, "Assertion 2a:" + data);
            Assert.IsTrue(date2 == _today.AddHours(13).AddMinutes(30), "Assertion 2b:" + data);
        }
     
        [Test]
        public void TestDateFormatC()
        {
            var data = "Craving pork? Catch us @RaleighBrewing tonight from 6-9";

            var date1 = _dates[0];
            var date2 = _dates[1];
            Assert.IsTrue(date1 == _today.AddHours(18).AddMinutes(00), "Assertion 3a:" + data);
            Assert.IsTrue(date2 == _today.AddHours(21).AddMinutes(00), "Assertion 3b:" + data);
        }
        [Test]
        public void TestDateFormatT35()
        {
            var data = "Catch us @Fullsteam today! 3-8pm. Melts &amp; brews. #grilledCheese";

            var date1 = _dates[0];
            var date2 = _dates[1];
            Assert.IsTrue(date1 == _today.AddHours(15).AddMinutes(00), "Assertion 4a:" + data);
            Assert.IsTrue(date2 == _today.AddHours(20).AddMinutes(00), "Assertion 4b:" + data);
        }

        
        [Test]
        public void TestDateFormatT37()
        {
            var data = "Original Data:Dumpling dinner, Carrboro! Back on our Spring menu: Bayside Chive, Mushroom Veggieling, Noodle Salad! At Cliff's Meat Market til 8:00 PM!";

            var date1 = _dates[0];
            var date2 = _dates[1];
            Assert.IsTrue(date1 == _today.AddHours(18).AddMinutes(00), "Assertion 5b:" + data);
            Assert.IsTrue(date2 == _today.AddHours(21).AddMinutes(00), "Assertion 5b:" + data);
        }
        //
        [Test]
        public void TestDateFormatT38()
        {
            var data = "@UNCPerformArts: @GreekGussys is here! Grab a bite before @Brooklyn_Rider tonight at 7:30. http://t.co/Z9Uzrs169S";

            var date1 = _dates[0];
            var date2 = _dates[1];
            Assert.IsTrue(date1 == _today.AddHours(19).AddMinutes(30), "Assertion 5a:" + date1 + "," + _today);
            Assert.IsTrue(date2 == _today.AddHours(21).AddMinutes(30), "Assertion 5b:" + data);
        }
        [Test]
        public void TestDate_LunchTodayTil()
        {
            const string data = "Lunch today til 1:30 8041 Arco Corporate Dr #Raleigh http://t.co/hLGNVuSP9M";
            Parse(data);
            var dates = new DateTime[2];

            var date1 = dates[0];
            var date2 = dates[1];
            var expected = _today.AddHours(13).AddMinutes(30);
            Assert.AreEqual(_today.AddHours(11).AddMinutes(30), date1, "Time1 was " + date1);
            Assert.AreEqual(expected,date2, "Time2 was " + date2);
        }
        [Test]
        public void TestDate_DinnerTil()
        {
            var data = "Chillin like BoB Dylan here @RaleighBrewing dinner til 9pm 3709 Neil St #Raleigh";
            Parse(data);
            DateTime[] dates = new DateTime[2];

            var date1 = dates[0];
            var date2 = dates[1];

            Assert.IsTrue(date1 == _today.AddHours(18).AddMinutes(00), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(21).AddMinutes(00), "Time2 was " + date1);
        }
        [Test]
        public void TestDate_Lunch()
        {
            const string data = "It's Burnt End Wednesday!!! Come out to @ViewBar_Raleigh or the food truck for lunch at Centregreen office park, 3000 Cetregreen Way, #Cary.";
            Parse(data);
            var dates = new DateTime[2];

            var date1 = dates[0];
            var date2 = dates[1];

            Assert.IsTrue(date1 == _today.AddHours(11).AddMinutes(30), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(13).AddMinutes(30), "Time2 was " + date2);
        }

        [Test]
        public void TestDate_DE32()
        {
            var data =
                "Loved the holidays but happy to be back working! Lunch @ Cassidy Turley today from 11:30~1:30. (4000 WestChase Blvd, Raleigh)";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(11).AddMinutes(30), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(13).AddMinutes(30), "Time2 was " + date2);
        }
        [Test]
        public void TestDate_DE32_2()
        {
            var data ="Come Tailgate with @baguettaboutit today before the UNC Football game! 9am-12pm TODAY! Try our UEgginMeOn breakfast sandwich! @GoHeels @UNC";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(9), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(12), "Time2 was " + date2);
        }
        [Test]
        public void TestDate_DE32_3()
        {
            var data = "Put your money where your home is, this Holiday!! 12/14. 12pm-4pm. #DowntownCary http://fb.me/43zwpjHHO";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(12), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(16), "Time2 was " + date2);
        }
        [Test]
        public void TestDate_DE32_4()
        {
            var data = "Serving Beautiful Coffee Now at @HuntStMarket  @ 214 Hunt St, Durham, From 7:30AM Until 12:00PM http://foodtrucksin.com/caffe-bellezza-mobile-coffee-bar …";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(7).AddMinutes(30), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(12), "Time2 was " + date2);
        }
        [Test]
        public void TestDate_DE32_5()
        {
            var data = "Saturday waffles are in Durham from 8:30am to 12:30pm Big Eastern US Coffee Championship Durham Convention Center 301 W Morgan St";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(8).AddMinutes(30), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(12).AddMinutes(30), "Time2 was " + date2);
        }
        [Test]
        public void TestDate_DE32_6()
        {
            var data = "Keystone 523 Davis Drive Morrisville to be exact. We're in tech lot #1 follow your nose. For lunch today 11:30~1:30pm";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(11).AddMinutes(30), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(13).AddMinutes(30), "Time2 was " + date2);
        }
        [Test]
        public void TestDate_DE32_8()
        {
            var data = "NEW VENDORS IN DECEMBER! Downtown Cary Food & Flea| 12/14 | 12p-4p http://fb.me/6wyX8P720";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(12), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(16), "Time2 was " + date2);
        }
        [Test]
        public void TestDate_DE32_9()
        {
            var data = "Serving Now at Kenan Stadium - Bell Tower Lot C From 9:00AM Until 12:30PM EST http://foodtrucksin.com/dusty-donuts";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(9), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(12).AddMinutes(30), "Time2 was " + date2);
        }
        [Test]
        public void TestDate_WrongTimeOfDay()
        {
            var data = "Come on out and grab a cup of coffee or tea before and during work! We're at 2525 Meridian pkwy from 8-9:30 am";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(8), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(9).AddMinutes(30), "Time2 was " + date2);
        }
        [Test]
        public void TestDate_LunchTime()
        {
            var data = "RDU CENTER for lunch! ( 3131 RDU Center Drive Morrisville, NC 27560) ";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(11).AddMinutes(30), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(13).AddMinutes(30), "Time2 was " + date2);
        }
        [Test]
        public void TestDate_WrongStartDate()
        {
            var data = "@BigCatBobCat 2945 S. Miami blvd #Durham NC - on the corner of TW Alexander behind @sheetz :) We're open until 2 today!";
        //StartDate: 6/23/2014 2:00:00 AM
        //EndDate: 6/23/2014 12:09:47 PM";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(8), "Time1 was " + date1); //use default timestamp in test;
            Assert.IsTrue(date2 == _today.AddHours(14), "Time2 was " + date2);
        }      
        [Test]
        public void TestDate_Slashes()
        {
            var data ="The cold is not stopping us. If you're at work in @downtowndurham swing by for a melty #GrilledCheese.  300 North Duke St. 11:15am-1:15/30pm";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(11).AddMinutes(15), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(13).AddMinutes(30), "Time2 was " + date2);
        }
        [Test]
        public void Test_TomorrowFail()
        {
            // //Tomorrow, 12:00-1:30 @libertytax corporate offices 1716 Corporate Landing Pkwy VA Beach VA 23454!
            var data =  "Due to road conditions, we WILL NOT be at Duke Coffeehouse tonight.Back on Duke W Campus Quad tomorrow, 5-9:30!";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddDays(1).AddHours(17), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddDays(1).AddHours(21).AddMinutes(30), "Time2 was " + date2);          
        }

        [Test]
        public void Test_TomorrowFail2()
        {
            var data = "Tomorrow, 12:00-1:30 @libertytax corporate offices 1716 Corporate Landing Pkwy VA Beach VA 23454!";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddDays(1).AddHours(12), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddDays(1).AddHours(13).AddMinutes(30), "Time2 was " + date2);
        }

        [Test]
        public void Test_ParsedAsPM()
        {
            var data = "Come on out and grab a cup of coffee or tea before and during work! We're at 2525 Meridian pkwy from 8-9:30 am!! ";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(8), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(9).AddMinutes(30), "Time2 was " + date2);
        }

        [Test]
        public void Test_ParsedAsPM_2()
        {
            var data = "Tuesday breakfast 8:30-10:30am @ 2520 meridian parkway, Durham with @CaffeBellezza !";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(8).AddMinutes(30), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(10).AddMinutes(30), "Time2 was " + date2);
        }
        //
        [Test]
        public void Test_AddressWrong()
        {
            var data = "Saturday we'll be back @cocoacinnamon for breakfast 8-11am coffee, waffles, and @DurhamFarmerMkt what else?";
            Parse(data);
            var date1 = _dates[0];
            var date2 = _dates[1];

            Assert.IsTrue(date1 == _today.AddHours(8), "Time1 was " + date1);
            Assert.IsTrue(date2 == _today.AddHours(11), "Time2 was " + date2);
        }
        //#DukeU #DukeNation We were at Chapel. But now we are sold out. Catch us tomorrow on Wannamaker Fire Lane. 5-8:30
        //	RESULT 2/25/2015 5:00:00 AM	2/25/2015 8:30:00 AM	Fire Pink Way, Raleigh, NC 27613, USA
    }
}
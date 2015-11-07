using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Mnx.Antlr.Post.Grammars;
using Mnx.Antlr.Post.Listeners.Models;
using Mnx.Antlr.Post.Listeners.Validators;

namespace Mnx.Antlr.Post.Listeners
{
    public class DefaultListener : IPost_en_ParserListener
    {
        const string SPACE =" ";
        //private DateTime dateTime;
        private string _address;
        //private string identifier;
        //private bool repeating;
        //private string hyperlink;
        //
        public PostData Data { get; private set; }

        public void EnterPost(Post_en_Parser.PostContext context)
        {
            Data = new PostData();
            
        }
        public void EnterPhrase(Post_en_Parser.PhraseContext context)
        {
            _address = String.Empty; //done here to support multiple phrases per statement
        }

        public void ExitPhrase(Post_en_Parser.PhraseContext context)
        {
            Data.Location = new Location
            {
                Address = _address
            };
        }
        public void VisitTerminal(ITerminalNode node)
        {

        }

        public void VisitErrorNode(IErrorNode node)
        {
            //set status
        }

        public void EnterEveryRule(ParserRuleContext ctx)
        {

        }

        public void ExitEveryRule(ParserRuleContext ctx)
        {

        }

        public void EnterPhraseWithLocationLookup(Post_en_Parser.PhraseWithLocationLookupContext context)
        {
        }

        public void ExitPhraseWithLocationLookup(Post_en_Parser.PhraseWithLocationLookupContext context)
        {
        }

        public void EnterPhraseWithDayOfWeek(Post_en_Parser.PhraseWithDayOfWeekContext context)
        {
        }

        public void ExitPhraseWithDayOfWeek(Post_en_Parser.PhraseWithDayOfWeekContext context)
        {
        }

        public void EnterPhraseWithAddress(Post_en_Parser.PhraseWithAddressContext context)
        {
        }

        public void ExitPhraseWithAddress(Post_en_Parser.PhraseWithAddressContext context)
        {
        }

        public void EnterPhraseWithTimeOfDay(Post_en_Parser.PhraseWithTimeOfDayContext context)
        {
        }

        public void ExitPhraseWithTimeOfDay(Post_en_Parser.PhraseWithTimeOfDayContext context)
        {
        }

        public void ExitPost(Post_en_Parser.PostContext context)
        {
           var validator = new PostDataValidator();
            var result = validator.Validate(Data);
            Debug.WriteLine("Valid Data: " + result.IsValid);
        }


        public void EnterStatement(Post_en_Parser.StatementContext context)
        {

        }

        public void ExitStatement(Post_en_Parser.StatementContext context)
        {

        }

        public void EnterSubject(Post_en_Parser.SubjectContext context)
        {

        }

        public void ExitSubject(Post_en_Parser.SubjectContext context)
        {

        }

        public void EnterAuxiliary_verb_phrase(Post_en_Parser.Auxiliary_verb_phraseContext context)
        {
        }

        public void ExitAuxiliary_verb_phrase(Post_en_Parser.Auxiliary_verb_phraseContext context)
        {
        }

        public void EnterTransitive_verb_phrase(Post_en_Parser.Transitive_verb_phraseContext context)
        {
        }

        public void ExitTransitive_verb_phrase(Post_en_Parser.Transitive_verb_phraseContext context)
        {
        }

        public void EnterStreet_address(Post_en_Parser.Street_addressContext context)
        {
        }

        public void ExitStreet_address(Post_en_Parser.Street_addressContext context)
        {

            var numberText = string.Empty;
            var streetText = string.Empty;
            var number = context.DIGIT();
            var street = context.IDENTIFIER();
            var streetdesignator = context.STREETDESIGNATOR() ?? context.STREETDESIGNATORLONG();
            var city = context.CITY();//validate with db or db derived corpus

            numberText = number.Aggregate(numberText, (current, item) => string.Concat(current, item.GetText()));
            streetText = street.Aggregate(streetText, (current, item) => string.Concat(current, SPACE, item.GetText()));
            var streetdesignatorText = streetdesignator.GetText();
            var cityText = city.GetText();

            var result = new StringBuilder();
            result.Append(numberText)
                .Append(streetText)
                .Append(streetdesignatorText)
                .Append(cityText);
            _address = result.ToString();
            //or is it just this?
            //_address = context.GetText();
        }

        public void EnterDigits(Post_en_Parser.DigitsContext context)
        {
        }

        public void ExitDigits(Post_en_Parser.DigitsContext context)
        {
        }

        public void EnterUnknowns(Post_en_Parser.UnknownsContext context)
        {
        }

        public void ExitUnknowns(Post_en_Parser.UnknownsContext context)
        {
        }
    }
}

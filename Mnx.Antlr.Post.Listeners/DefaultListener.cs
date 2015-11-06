using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Mnx.Antlr.Post.Grammars;
using Mnx.Antlr.Post.Listeners.Models;
using Mnx.Antlr.Post.Listeners.Validators;

namespace Mnx.Antlr.Post.Listeners
{
    public class DefaultListener : IPost_en_ParserListener
    {
        public PostData Data { get; private set; }

        //class PostEvent
        //clear on Enter?? to support multiple events per post
        //private DateTime dateTime;
        //private string address;
        //private string identifier;
        //private bool repeating;
        //private string hyperlink;
        //

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

        public void EnterPost(Post_en_Parser.PostContext context)
        {
            Data = new PostData();
        }

        public void ExitPost(Post_en_Parser.PostContext context)
        {
           var validator = new PostDataValidator();
            var result = validator.Validate(Data);
            Debug.WriteLine("Valid Data: " + result.IsValid);
        }

        public void EnterDayOfWeek(Post_en_Parser.DayOfWeekContext context)
        {

        }

        public void ExitDayOfWeek(Post_en_Parser.DayOfWeekContext context)
        {

        }

        public void EnterTimeOfDay(Post_en_Parser.TimeOfDayContext context)
        {

        }

        public void ExitTimeOfDay(Post_en_Parser.TimeOfDayContext context)
        {

        }

        public void EnterLocationLookup(Post_en_Parser.LocationLookupContext context)
        {

        }

        public void ExitLocationLookup(Post_en_Parser.LocationLookupContext context)
        {

        }

        public void EnterStatement(Post_en_Parser.StatementContext context)
        {

        }

        public void ExitStatement(Post_en_Parser.StatementContext context)
        {

        }

        public void EnterPhrase(Post_en_Parser.PhraseContext context)
        {

        }

        public void ExitPhrase(Post_en_Parser.PhraseContext context)
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

        public void EnterDigits(Post_en_Parser.DigitsContext context)
        {
        }

        public void ExitDigits(Post_en_Parser.DigitsContext context)
        {
        }
    }
}

using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Mnx.Antlr.Post.Grammars;
using Mnx.Antlr.Post.Listeners.Models;

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
            throw new NotImplementedException();
        }

        public void VisitErrorNode(IErrorNode node)
        {
            throw new NotImplementedException();
        }

        public void EnterEveryRule(ParserRuleContext ctx)
        {
            throw new NotImplementedException();
        }

        public void ExitEveryRule(ParserRuleContext ctx)
        {
            throw new NotImplementedException();
        }

        public void EnterPost(Post_en_Parser.PostContext context)
        {
            Data = new PostData();           
        }

        public void ExitPost(Post_en_Parser.PostContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterDayOfWeek(Post_en_Parser.DayOfWeekContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitDayOfWeek(Post_en_Parser.DayOfWeekContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterTimeOfDay(Post_en_Parser.TimeOfDayContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitTimeOfDay(Post_en_Parser.TimeOfDayContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterLocationLookup(Post_en_Parser.LocationLookupContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitLocationLookup(Post_en_Parser.LocationLookupContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStatement(Post_en_Parser.StatementContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStatement(Post_en_Parser.StatementContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterPhrase(Post_en_Parser.PhraseContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitPhrase(Post_en_Parser.PhraseContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterSubject(Post_en_Parser.SubjectContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitSubject(Post_en_Parser.SubjectContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterPredicate(Post_en_Parser.PredicateContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitPredicate(Post_en_Parser.PredicateContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterObject(Post_en_Parser.ObjectContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitObject(Post_en_Parser.ObjectContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterVerb(Post_en_Parser.VerbContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitVerb(Post_en_Parser.VerbContext context)
        {
            throw new NotImplementedException();
        }
    }
}

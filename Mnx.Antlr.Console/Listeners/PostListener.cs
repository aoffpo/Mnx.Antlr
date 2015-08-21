using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Mnx.Antlr.Grammars.Grammars.Post.en;

namespace Mnx.Antlr.Console.Listeners
{
    public class PostListener : IPost_en_ParserListener
    {
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
            throw new NotImplementedException();
        }

        public void ExitPost(Post_en_Parser.PostContext context)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using Mnx.Antlr.Cron.Grammar;

namespace Mnx.Antlr.Cron.Listeners
{
    public class CronListener : ICronParserListener
    {
        public void EnterCompileUnit(CronParser.CompileUnitContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitCompileUnit(CronParser.CompileUnitContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterEveryRule(Antlr4.Runtime.ParserRuleContext ctx)
        {
            throw new NotImplementedException();
        }

        public void ExitEveryRule(Antlr4.Runtime.ParserRuleContext ctx)
        {
            throw new NotImplementedException();
        }

        public void VisitErrorNode(Antlr4.Runtime.Tree.IErrorNode node)
        {
            throw new NotImplementedException();
        }

        public void VisitTerminal(Antlr4.Runtime.Tree.ITerminalNode node)
        {
            throw new NotImplementedException();
        }
    }
}

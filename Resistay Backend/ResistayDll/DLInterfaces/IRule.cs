using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResistayDLL.Bl;

namespace ResistayDll.DLInterfaces
{
    public interface IRule
    {
        bool AddRule(Rule rule);
        bool DeleteRule(int ruleId);
        List<Rule> GetAllRules();
        List<int> GetRuleIds();
    }
}

namespace IrisProblems
{
    public class BalancedBracketsService
    {
        private const string NotBalanced = "Not Balanced";
        private const string Balanced = "Balanced";

        public string CheckExpressionWithList(string expression)
        {
            List<char> bracketsMatchList = new List<char>();

            foreach (var bracket in expression)
            {
                if (bracket == '[' || bracket == '(' || bracket == '{')
                {
                    bracketsMatchList.Add(bracket);
                }

                else if (bracket == ']' && bracketsMatchList.LastOrDefault() != '[')
                {
                    return NotBalanced;
                }
                else if (bracket == ')' && bracketsMatchList.LastOrDefault() != '(')
                {
                    return NotBalanced;
                }
                else if (bracket == '}' && bracketsMatchList.LastOrDefault() != '{')
                {
                    return NotBalanced;
                }

                else
                {
                    bracketsMatchList.RemoveAt(bracketsMatchList.Count - 1);
                }
            }

            return bracketsMatchList.Count == 0 ? Balanced : NotBalanced;

        }

        public string CheckExpressionWithStack(string expression)
        {
            Stack<char> bracketsMatchList = new Stack<char>();

            foreach (var bracket in expression)
            {
                if (bracket == '[' || bracket == '(' || bracket == '{')
                {
                    bracketsMatchList.Push(bracket);
                }

                else if (bracket == ')' && (bracketsMatchList.Count == 0 || bracketsMatchList.Pop() != '('))
                {
                    return NotBalanced;
                }
                else if (bracket == ']' && (bracketsMatchList.Count == 0 || bracketsMatchList.Pop() != '['))
                {
                    return NotBalanced;
                }
                else if (bracket == '}' && (bracketsMatchList.Count == 0 || bracketsMatchList.Pop() != '{'))
                {
                    return NotBalanced;
                }
            }

            return bracketsMatchList.Count == 0 ? Balanced : NotBalanced;

        }
    }
}

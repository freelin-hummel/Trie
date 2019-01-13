

namespace Trie
{
    public class Trie
    {
        TrieNode Root { get; } = new TrieNode('^');

        public Trie()
        {

        }

        public void Insert(string s)
        {
            var current = Root;

            foreach (char c in s)
            {
                current = current.FindOrCreateChild(c);
            }

            current.IsTerminalCharacter = true;
        }

        public bool Search(string s)
        {
            if (s == null)
                return false;

            var current = Root;

            foreach (char c in s)
            {
                current = current.FindChild(c);

                if (current == null)
                {
                    return false;
                }
            }

            return current.IsTerminalCharacter;
        }
    }
}

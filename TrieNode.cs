using System.Collections.Generic;
using System.Linq;

namespace Trie
{
    public class TrieNode
    {
        public HashSet<TrieNode> Children { get; } = new HashSet<TrieNode>();
        public bool IsTerminalCharacter { get; set; } = false;
        public char Value { get; }

        public TrieNode FindChild(char c)
        {
            return Children.FirstOrDefault(t => t.Value == c);
        }

        public TrieNode FindOrCreateChild(char c)
        {
            var child = FindChild(c);

            if (child == null)
            {
                child = new TrieNode(c);
                Children.Add(child);
            }

            return child;
        }

        public TrieNode(char value)
        {
            Value = value;
        }
    }
}

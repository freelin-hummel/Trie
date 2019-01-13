

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            var trie = new Trie();

            //simple tests
            trie.Insert("a/bcd");
            var y = trie.Search("a/bcd");
            var x = trie.Search("abc");
            trie.Insert("abc");
            y = trie.Search("a/bcd");
        }
    }
}

class Scripture
{
    private Reference Reference;
    private List<Word> Words;
    private Random random;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
        random = new Random();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Reference.GetFormattedReference());
        Console.WriteLine(string.Join(" ", Words.Select(w => w.GetDisplayText())));
    }

    public void HideWords(int count)
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        
        if (visibleWords.Count == 0) return;

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(w => w.IsHidden);
    }
}
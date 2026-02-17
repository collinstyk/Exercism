using System.ComponentModel;
using System.Linq.Expressions;

public static class RnaTranscription
{
    public static string ToRna(string strand)
    {
        string rnaStrand = "";
        foreach (char nucleotide in strand)
        {
            switch (nucleotide)
            {
                case 'A':
                    rnaStrand += 'U';
                    break;
                case 'C':
                    rnaStrand += 'G';
                    break;
                case 'G':
                    rnaStrand += 'C';
                    break;
                case 'T':
                    rnaStrand += 'A';
                    break;
                default:
                    throw new ArgumentException($"Invalid DNA base {nucleotide}");
            }
        }
        return rnaStrand;
    }
}
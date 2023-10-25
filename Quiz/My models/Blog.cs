using Quiz.My_enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.My_models
{
    public class Blog
    {
        private string description;
        private string title;
        private static int _id;
        public string Description
        {
            get { return description; }
            set=>Console.WriteLine($"Animals are multicellular, eukaryotic organisms in the biological kingdom Animalia. With few exceptions, animals consume organic material, breathe oxygen, have myocytes and are able to move, can reproduce sexually, and grow from a hollow sphere of cells, the blastula, during embryonic development. As of 2022, 2.16 million living animal species have been described—of which around 1.05 million are insects, over 85,000 are molluscs, and around 65,000 are vertebrates. It has been estimated there are around 7.77 million animal species. Animals range in length from 8.5 micrometres (0.00033 in) to 33.6 metres (110 ft). They have complex interactions with each other and their environments, forming intricate food webs. The scientific study of animals is known as zoology.");
        }
        public string Title
        {
            get => title;
            set => Console.WriteLine($"Animals");
        }
       
        public BlogType BlogType { get; set; }  
        public Blog(int id,string title,string description)
        {
            _id++;
            id = _id;
            Title = title;
            Description = description;

        }

    }
}

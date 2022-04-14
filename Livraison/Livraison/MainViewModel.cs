using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Livraison
{

   public  class MainViewModel
    {
        private ClientModel _OldClient;
        public ObservableCollection<ClientModel> Articles;

        public MainViewModel ()
        {
            Articles = new ObservableCollection<ClientModel>()
            {
                new ClientModel
                {
                    Name = " Mme X",
                    Number = 60000000,
                    Signature = "Yes i approuve",
                    ImageUrl= "Chocolat.JPEG",
                    collImage = "plus.png",
                    ExpImage = "minus.png",
                    IsVisible = false ,

                    ClientDetails = new ObservableCollection<ClientDetails>
                    {
                        new ClientDetails {key="Anil", value="Pragati"},
                        new ClientDetails {key="Anil", value="Pragati"},
                        new ClientDetails {key="Anil", value="Pragati"},
                        new ClientDetails {key="Anil", value="Pragati"},
                        new ClientDetails {key="Anil", value="Pragati"},
                        new ClientDetails {key="Anil", value="Pragati"},
                        new ClientDetails {key="Anil", value="Pragati"},
                        new ClientDetails {key="Anil", value="Pragati"}
                    }
                },
                 new ClientModel
                {
                    Name = " Mme Y",
                    Number = 600669000,
                    Signature = "Yes i approuve",
                    ImageUrl= "Velo .JPEG",
                    collImage = "plus.png",
                    ExpImage = "minus.png",
                    IsVisible = false,

                    
                },

                  new ClientModel
                {
                    Name = " Mr R",
                    Number = 6669000,
                    Signature = "Yes i approuve",
                    ImageUrl= "JOUET.JPEG",
                    collImage = "plus.png",
                    ExpImage = "minus.png",
                    IsVisible = false,


                },


                   new ClientModel
                {
                    Name = " Mr A",
                    Number = 601169000,
                    Signature = "Yes i approuve",
                    ImageUrl= " Chaussures.JPEG",
                    collImage = "plus.png",
                    ExpImage = "minus.png",
                    IsVisible = false,


                },


            };
            
        }

    }

    public class ClientModel
    {
       public string Name { get; set; }

       public int Number { get; set; }

        public string  Signature { get; set; }

        public string collImage { get; set;}

        public string ImageUrl { get; set; }

        public string ExpImage { get; set; }

        public ObservableCollection <ClientDetails>  ClientDetails { get; set; }
        public bool IsVisible { get; internal set; }
    }

    public class ClientDetails
    {
        public  string key { get; set; }

        public string value { get; set; }
    }
}


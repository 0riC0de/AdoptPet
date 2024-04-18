using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat : Animal
    {
        public CatBreeds Breed { get; set; }
    }
    public enum CatBreeds
    {
        Abyssinian,
        American_Bobtail,
        American_Curl,
        American_Shorthair,
        American_Wirehair,
        Balinese,
        Bengal,
        Birman,
        Bombay,
        British_Shorthair,
        Burmese,
        Chartreux,
        Colorpoint_Shorthair,
        Cornish_Rex,
        Cymric,
        Devon_Rex,
        Egyptian_Mau,
        European_Burmese,
        Exotic_Shorthair,
        Havana_Brown,
        Himalayan,
        Japanese_Bobtail,
        Javanese,
        Korat,
        LaPerm,
        Maine_Coon,
        Manx,
        Munchkin,
        Nebelung,
        Norwegian_Forest_Cat,
        Ocicat,
        Oriental,
        Persian,
        Peterbald,
        Pixiebob,
        Ragamuffin,
        Ragdoll,
        Russian_Blue,
        Savannah,
        Scottish_Fold,
        Selkirk_Rex,
        Siamese,
        Siberian,
        Singapura,
        Snowshoe,
        Somali,
        Sphynx,
        Tonkinese,
        Turkish_Angora,
        Turkish_Van,
    }
}

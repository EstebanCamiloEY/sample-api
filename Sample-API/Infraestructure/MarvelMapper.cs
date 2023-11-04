using AutoMapper;
using Sample_API.Infraestructure.DAO;
using Sample_API.Service.Models;

namespace Sample_API.Infraestructure
{
    public class MarvelMapper : Profile
    {
        public MarvelMapper() {
            CreateMap<CharacterDAO.Result, Character>();
            CreateMap<CharacterDAO.Comics, Character.Comics>();
            CreateMap<CharacterDAO.Series, Character.Series>();
            CreateMap<CharacterDAO.Stories, Character.Stories>();
            CreateMap<CharacterDAO.Events, Character.Events>();
            CreateMap<CharacterDAO.Url, Character.Url>();

            CreateMap<CharacterDAO.Item, Character.Item> ();
            CreateMap<CharacterDAO.Item1, Character.Item1> ();
            CreateMap<CharacterDAO.Item2, Character.Item2>();
            CreateMap<CharacterDAO.Item3, Character.Item3>();

            CreateMap<ComicDAO.Series, Character.Series>();
            CreateMap<ComicDAO.Stories, Character.Stories>();
            CreateMap<ComicDAO.Events, Character.Events>();
            CreateMap<ComicDAO.Url, Character.Url>();

            CreateMap<ComicDAO.Item, Character.Item>();
            CreateMap<ComicDAO.Item1, Character.Item1>();
            CreateMap<ComicDAO.Item2, Character.Item2>();

            CreateMap<ComicDAO.Result, Comic>();
            CreateMap<ComicDAO.Variant, Comic.Variant>();
            CreateMap<ComicDAO.Date, Comic.Date>();
            CreateMap<ComicDAO.Price, Comic.Price>();
            CreateMap<ComicDAO.Image, Comic.Image>();
            CreateMap<ComicDAO.Creators, Comic.Creators>();
            CreateMap<ComicDAO.Characters, Comic.Characters>();
        }
    }
}

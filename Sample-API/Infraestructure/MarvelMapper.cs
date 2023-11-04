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

            CreateMap<ComicDAO.Result, Comic>();
            CreateMap<ComicDAO.Series, Comic.Series>();
            CreateMap<ComicDAO.Variant, Comic.Variant>();
            CreateMap<ComicDAO.Date, Comic.Date>();
            CreateMap<ComicDAO.Price, Comic.Price>();
            CreateMap<ComicDAO.Image, Comic.Image>();
            CreateMap<ComicDAO.Creators, Comic.Creators>();
            CreateMap<ComicDAO.Characters, Comic.Characters>();
            CreateMap<ComicDAO.Stories, Comic.Stories>();
            CreateMap<ComicDAO.Events, Comic.Events>();
            CreateMap<ComicDAO.Url, Comic.Url>();

            CreateMap<ComicDAO.Item, Comic.Item>();
            CreateMap<ComicDAO.Item1, Comic.Item1>();
            CreateMap<ComicDAO.Item2, Comic.Item2>();
        }
    }
}

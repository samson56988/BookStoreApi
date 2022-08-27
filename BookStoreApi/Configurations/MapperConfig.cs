using AutoMapper;
using BookStoreApi.Data;
using BookStoreApi.Models.Authors;
using BookStoreApi.Models.Books;

namespace BookStoreApi.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();
            CreateMap<BookCreateDto, Book>().ReverseMap();
            CreateMap<BookUpdateDto, Book>().ReverseMap();
            CreateMap<Book, BookReadOnlyDto>()
                .ForMember(q => q.AuthorName, d => d.MapFrom(map => $"{map.Author.Firstname} {map.Author.Lastname}"))
                .ReverseMap();
            CreateMap<Book, BookDetailsDto>()
               .ForMember(q => q.AuthorName, d => d.MapFrom(map => $"{map.Author.Firstname} {map.Author.Lastname}"))
               .ReverseMap();

        }
    }
}

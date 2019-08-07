using System;
using AutoMapper;
using backend.Models;
using backend.dto;
public class MappingProfile : Profile{
   public MappingProfile(){
  
      CreateMap<Artist, ArtistDto>();
      CreateMap<ArtistTranslation, ArtistTranslationDto>();
      CreateMap<Language, LanguageDto>();
      CreateMap<Movement, MovementDto>();
      CreateMap<MovementTranslation, MovementTranslationDto>();
      CreateMap<PaintingAudio, PaintingAudioDto>();
      CreateMap<Painting, PaintingDto>();
      CreateMap<PaintingStory, PaintingStoryDto>();
      CreateMap<PaintingTranslation, PaintingTranslationDto>();
      CreateMap<Technique, TechniqueDto>();
      CreateMap<TechniqueTranslation, TechniqueTranslationDto>();
      CreateMap<Building, BuildingDto>();
      CreateMap<BuildingTranslation, BuildingTranslationDto>();
      CreateMap<Use, UseDto>();
      CreateMap<UseTranslation, UseTranslationDto>();
   }
}
using System;
using AutoMapper;
using backend.Models;
public class MappingProfile : Profile{
   public MappingProfile(){
  
      CreateMap<Painting, PaintingDto>();
      CreateMap<Artist, ArtistDto>();
      CreateMap<Movement, MovementDto>();
      CreateMap<PaintingAudio, PaintingAudioDto>();
      CreateMap<PaintingStory, PaintingStoryDto>();
      CreateMap<Technique, TechniqueDto>();
   }
}
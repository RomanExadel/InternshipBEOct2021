﻿using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Threading.Tasks;

namespace BL.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FeedbackService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<FeedbackDTO> CreateFeedbackAsync(FeedbackDTO newFeedback)
        {
            var feedback = await _unitOfWork.Feedbacks.CreateAsync(_mapper.Map<Feedback>(newFeedback));

            await _unitOfWork.SaveAsync();

            return _mapper.Map<FeedbackDTO>(feedback);
        }

        public async Task<FeedbackDTO> GetFeedbackByIdAsync(int id)
        {
            return _mapper.Map<FeedbackDTO>(await _unitOfWork.Feedbacks.GetByIdAsync(id));
        }

        public async Task<FeedbackDTO> UpdateFeedbackAsync(FeedbackDTO updatedFeedback)
        {
            var feedback = await _unitOfWork.Feedbacks.UpdateAsync(_mapper.Map<Feedback>(updatedFeedback));

            await _unitOfWork.SaveAsync();

            return _mapper.Map<FeedbackDTO>(feedback);
        }
    }
}
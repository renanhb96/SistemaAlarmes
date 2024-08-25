﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Application.Interfaces.Event
{
    public interface IGetEventByIdUseCase
    {
        Task<Domain.Entities.Event> ExecuteAsync(int id);
    }

}
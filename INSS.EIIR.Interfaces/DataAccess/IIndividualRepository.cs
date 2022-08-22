﻿using INSS.EIIR.Models;

namespace INSS.EIIR.Interfaces.DataAccess;

public interface IIndividualRepository
{
    IEnumerable<SearchResult> SearchByName(string firstName = "", string lastName = "");
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Illiterati.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Illiterati.Test;

[TestClass]
public class DataTests
{
    [TestMethod]
    public void DataIsLoaded()
    {
        var quizContext = new QuizContext();

        var works = quizContext.Works;

        var firstWork = works.Where(w => w.Id == 1)
                             .FirstOrDefault();

        var firstWorkGenres = firstWork.Genres.ToList();

        Assert.AreEqual(firstWorkGenres[0], "Epic Poetry");
    }
}
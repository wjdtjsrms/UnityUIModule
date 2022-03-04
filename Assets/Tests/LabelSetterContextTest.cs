using Anipen.MetaPubs.UI;
using NUnit.Framework;

public class LabelSetterContextTest
{
    private static string TESTCONTEXT = "Testing!@#$%^&*()_+-=";

    [Test]
    public void TextChagne()
    {
        #region Member
        var labelSetterContext = new LabelSetterContext();
        #endregion

        #region Test
        labelSetterContext.MyText = TESTCONTEXT;
        #endregion

        #region Assert
        Assert.AreEqual(TESTCONTEXT, labelSetterContext.MyText);
        #endregion
    }

    [Test]
    public void ButtonClick()
    {
        #region Member
        var labelSetterContext = new LabelSetterContext();
        var prevText = labelSetterContext.MyText;
        #endregion

        #region Test
        labelSetterContext.OnClickButton();
        #endregion

        #region Assert
        Assert.AreNotEqual(prevText, labelSetterContext.MyText);
        #endregion
    }
}

using OnCallDeveloperApi.Services;



namespace OnCallDeveloperApi.UnitTests;



public class SupporScheduleTests
{
    [Fact]
    public void NoInHouseSupportOnWeekends()
    {
        var supportSchedule = new SupportSchedule();



        Assert.False(supportSchedule.InternalSupportAvailable);
    }
    [Fact]
    public void InHouseSupportOnWeekDays()
    {
        var supportSchedule = new SupportSchedule();



        Assert.True(supportSchedule.InternalSupportAvailable);
    }
}
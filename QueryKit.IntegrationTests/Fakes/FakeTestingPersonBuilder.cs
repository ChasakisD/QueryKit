namespace QueryKit.IntegrationTests.Fakes;

using AutoBogus;
using WebApiTestProject.Entities;

public class FakeTestingPersonBuilder
{
    private readonly TestingPerson _baseTestingPerson = new AutoFaker<TestingPerson>().Generate();
    
    public FakeTestingPersonBuilder WithTitle(string title)
    {
        _baseTestingPerson.Title = title;
        return this;
    }

    public TestingPerson Build() => _baseTestingPerson;
}
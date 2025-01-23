using FluentAssertions;
using CleanArchMvc.Domain.Validation;
using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Domain.Tests;

public class CategoryUnitTest1
{
    [Fact(DisplayName = "Create Category With Valid State")]
    public void CreateCategory_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Category(1, "Category Name");
        action.Should()
              .NotThrow<DomainExceptionValidation>();
    }
}

using Xunit;
using StrategyPattern;
using System;

namespace StrategyPattern.Test
{
    public class NavigationTests
    {
        [Fact]
        public void WalkingStrategy_EstimateTime_CalculatesCorrectly()
        {
            // Arrange
            var strategy = new WalkingStrategy();
            var distance = 5.0; // 5 km
            var expectedTime = 1.0; // 1 hour (5 km at 5 km/h)

            // Act
            var actualTime = strategy.EstimateTime(distance);

            // Assert
            Assert.Equal(expectedTime, actualTime);
        }

        [Fact]
        public void DrivingStrategy_EstimateTime_CalculatesCorrectly()
        {
            // Arrange
            var strategy = new DrivingStrategy();
            var distance = 120.0; // 120 km
            var expectedTime = 2.0; // 2 hours (120 km at 60 km/h)

            // Act
            var actualTime = strategy.EstimateTime(distance);

            // Assert
            Assert.Equal(expectedTime, actualTime);
        }

        [Fact]
        public void NavigationContext_SetStrategy_ChangesStrategySuccessfully()
        {
            // Arrange
            var context = new NavigationContext(new DrivingStrategy());
            var newStrategy = new WalkingStrategy();

            // Act
            context.SetStrategy(newStrategy);
            var route = context.GetRoute("A", "B");

            // Assert
            Assert.Contains("Walking route", route);
        }

        [Fact]
        public void NavigationContext_NullStrategy_ThrowsArgumentNullException()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentNullException>(() => new NavigationContext(null));
        }

        [Fact]
        public void NavigationContext_EmptyStartPoint_ThrowsArgumentException()
        {
            // Arrange
            var context = new NavigationContext(new WalkingStrategy());

            // Act & Assert
            Assert.Throws<ArgumentException>(() => context.GetRoute("", "Destination"));
        }
    }
}
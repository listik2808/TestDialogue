using Scrips.Services.Input;
using UnityEngine;

namespace Scrips.Infrastructure
{
  public class Game
  {
    public static IInputService InputService;

    public Game()
    {
      RegisterInputInput();
    }

    private static void RegisterInputInput()
    {
      if (Application.isEditor)
        InputService = new StandaloneInputService();
      else
        InputService = new MobileInputService();
    }
  }
}
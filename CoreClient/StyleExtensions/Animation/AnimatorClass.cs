using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CoreClient.StyleExtensions.Animation
{
    public static class AnimatorClass
    {
        public static List<AnimationClass> AnimationList = new List<AnimationClass>();

        public static int Count() => AnimationList.Count;

        private static Thread AnimatorThread;

        private static double Interval;

        public static bool IsWork = false;

        public static void Start()
        {
            IsWork = true;
            Interval = 14; // FPS ~66

            AnimatorThread = new Thread(AnimationInvoker)
            {
                IsBackground = true,
                Name = "UI Animation"
            };

            AnimatorThread.Start();
        }

        private static void AnimationInvoker()
        {
            while (IsWork)
            {
                AnimationList.RemoveAll(a => a == null || a.Status == AnimationClass.AnimationStatus.Completed);

                Parallel.For(0, Count(), index => AnimationList[index].UpdateFrame());

                Thread.Sleep((int)Interval);
            }
        }

        public static void Request(AnimationClass Anim, bool ReplaceIfExists = true)
        {
            //Debug.WriteLine("Запуск анимации: " + Anim.ID + "| TargetValue: " + Anim.TargetValue);
            Anim.Status = AnimationClass.AnimationStatus.Requested;

            AnimationClass dupAnim = GetDuplicate(Anim);

            if (dupAnim != null)
            {
                if (ReplaceIfExists == true)
                {
                    dupAnim.Status = AnimationClass.AnimationStatus.Completed;
                }
                else
                {
                    return;
                }
            }

            AnimationList.Add(Anim);
        }

        private static AnimationClass GetDuplicate(AnimationClass Anim) => AnimationList.Find(a => a.ID == Anim.ID);
    }
}

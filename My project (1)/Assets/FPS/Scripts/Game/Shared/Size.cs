using UnityEngine;
using UnityEngine.Events;

namespace Unity.FPS.Game
{
    public class Size : MonoBehaviour
    {
        [Tooltip("Maximum amount of Size")] public float MaxSize = 0f;

        public UnityAction<float> OnShrink;
        public UnityAction<float> OnGrow;

        public float CurrentSize { get; set; }

        void Start()
        {
            CurrentSize = MaxSize;
        }

        public void Shrink(float shrinkAmount)
        {
            float sizeBefore = CurrentSize;
            CurrentSize -= shrinkAmount;
            CurrentSize = Mathf.Clamp(CurrentSize, 0f, MaxSize);

            // call OnShrink action
            float trueSizeAmount = CurrentSize - sizeBefore;
            if (trueSizeAmount > 0f)
            {
                OnShrink?.Invoke(trueSizeAmount);
            }
        }

        public void Grow(float growAmount)
        {
            float sizeBefore = CurrentSize;
            CurrentSize += growAmount;
            CurrentSize = Mathf.Clamp(CurrentSize, 0f, MaxSize);

            // call OnGrow action
            float trueSizeAmount = CurrentSize + sizeBefore;
            if (trueSizeAmount > 0f)
            {
                OnGrow?.Invoke(trueSizeAmount);
            }
        }
    }
}
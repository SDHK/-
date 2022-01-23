using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SDHK_Extension
{
    public static class TransformExtension
    {
        /// <summary>
        /// 将Transform数值设置为默认，旋转0，位置0，大小1
        /// </summary>
        public static Transform Default(this Transform tf)
        {
            tf.localRotation = Quaternion.identity;
            tf.localPosition = Vector3.zero;
            tf.localScale = Vector3.one;
            return tf;
        }

        /// <summary>
        /// 获取RectTransform
        /// </summary>
        public static RectTransform GetRectTransform(this Transform tf)
        {
            if (tf is RectTransform)
            {
                return tf as RectTransform;
            }
            else
            {
                return tf.gameObject.AddComponent<RectTransform>();
            }
        }

        /// <summary>
        /// 深度查找子物体
        /// </summary>
        /// <param name="childName">子物体名</param>
        public static Transform FindChildDeep(this Transform root, string childName)
        {
            Transform x = root.Find(childName);//查找名字为childName的子物体
            if (x != null)
            {
                return x;
            }

            for (int i = 0; i < root.childCount; i++)
            {
                Transform childTF = root.GetChild(i);
                x = childTF.FindChildDeep(childName);
                if (x != null)
                {
                    return x;
                }
            }
            return null;
        }

    }
}
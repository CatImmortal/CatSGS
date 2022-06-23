using System.Collections.Generic;

namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 整数数值
    /// </summary>
    public class IntNumeric
    {
        private int baseValue;
        public int BaseValue
        {
            get => baseValue;

            set
            {
                baseValue = value;
                Refresh();
            }
        }
        public int ExtraValue { get; private set; }
        public int FinaleValue { get; private set; }
        
        private List<IntModifier> extraModifiers = new List<IntModifier>();
        
        /// <summary>
        /// 添加额外加成
        /// </summary>
        public void AddExtraModifier(IntModifier modifier)
        {
            extraModifiers.Add(modifier);
            ExtraValue = 0;
            foreach (IntModifier intModifier in extraModifiers)
            {
                ExtraValue += intModifier.Value;
            }
            Refresh();
        }
        
        /// <summary>
        /// 移除额外加成
        /// </summary>
        public void RemoveExtraModifier(IntModifier modifier)
        {
            extraModifiers.Remove(modifier);
            foreach (IntModifier intModifier in extraModifiers)
            {
                ExtraValue += intModifier.Value;
            }
            Refresh();
        }

        private void Refresh()
        {
            FinaleValue = baseValue + ExtraValue;
        }

        public override string ToString()
        {
            return FinaleValue.ToString();
        }

        public static implicit operator int(IntNumeric self)
        {
            return self.FinaleValue;
        }
    }
}
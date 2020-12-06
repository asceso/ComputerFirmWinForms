namespace PermissionsManager
{
    public static class PermissionNames
    {
        #region clients -- Клиенты

        /// <summary>
        /// Получение клиентов
        /// </summary>
        public const string ClientsGet = nameof(ClientsGet);

        /// <summary>
        /// Добавление клиента
        /// </summary>
        public const string ClientsIns = nameof(ClientsIns);

        /// <summary>
        /// Изменение клиента
        /// </summary>
        public const string ClientsUpd = nameof(ClientsUpd);

        /// <summary>
        /// Удаление клиента
        /// </summary>
        public const string ClientsDel = nameof(ClientsDel);

        #endregion

        #region positions -- Должности

        /// <summary>
        /// Получение должностей
        /// </summary>
        public const string PositionsGet = nameof(PositionsGet);

        /// <summary>
        /// Добавление должностей
        /// </summary>
        public const string PositionsIns = nameof(PositionsIns);

        /// <summary>
        /// Изменение должностей
        /// </summary>
        public const string PositionsUpd = nameof(PositionsUpd);

        /// <summary>
        /// Удаление должностей
        /// </summary>
        public const string PositionsDel = nameof(PositionsDel);

        #endregion

        #region users -- сотрудники

        /// <summary>
        /// Получение сотрудников
        /// </summary>
        public const string UsersGet = nameof(UsersGet);

        /// <summary>
        /// Добавление сотрудника
        /// </summary>
        public const string UsersIns = nameof(UsersIns);

        /// <summary>
        /// Изменение сотрудника
        /// </summary>
        public const string UsersUpd = nameof(UsersUpd);

        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        public const string UsersDel = nameof(UsersDel);

        #endregion

        #region request types -- типы заявок

        /// <summary>
        /// Получение типов заявок
        /// </summary>
        public const string RequestTypesGet = nameof(RequestTypesGet);

        /// <summary>
        /// Добавление типов заявок
        /// </summary>
        public const string RequestTypesIns = nameof(RequestTypesIns);

        /// <summary>
        /// Изменение типов заявок
        /// </summary>
        public const string RequestTypesUpd = nameof(RequestTypesUpd);

        /// <summary>
        /// Удаление типов заявок
        /// </summary>
        public const string RequestTypesDel = nameof(RequestTypesDel);

        #endregion

        #region mounting req -- заявки на монтаж

        /// <summary>
        /// Получение заявок на монтаж
        /// </summary>
        public const string MountingRequestGet = nameof(MountingRequestGet);

        /// <summary>
        /// Добавление заявок на монтаж
        /// </summary>
        public const string MountingRequestIns = nameof(MountingRequestIns);

        /// <summary>
        /// Изменение заявок на монтаж
        /// </summary>
        public const string MountingRequestUpd = nameof(MountingRequestUpd);

        #endregion

        #region repair req -- заявки на ремонт

        /// <summary>
        /// Получение заявок на ремонт
        /// </summary>
        public const string RepairRequestGet = nameof(RepairRequestGet);

        /// <summary>
        /// Добавление заявок на ремонт
        /// </summary>
        public const string RepairRequestIns = nameof(RepairRequestIns);

        /// <summary>
        /// Изменение заявок на ремонт
        /// </summary>
        public const string RepairRequestUpd = nameof(RepairRequestUpd);

        #endregion

        #region sales -- продажи

        /// <summary>
        /// Получение продаж
        /// </summary>
        public const string SalesGet = nameof(SalesGet);

        /// <summary>
        /// Добавление продаж
        /// </summary>
        public const string SalesIns = nameof(SalesIns);

        /// <summary>
        /// Изменение продаж
        /// </summary>
        public const string SalesUpd = nameof(SalesUpd);

        #endregion

        #region permissions -- разрешения

        /// <summary>
        /// Добавление связи должность - разрешение
        /// </summary>
        public const string PositionPermissionIns = nameof(PositionPermissionIns);

        /// <summary>
        /// Удаление связи должность разрешение
        /// </summary>
        public const string PositionPermissionDel = nameof(PositionPermissionDel);

        #endregion
    }
}

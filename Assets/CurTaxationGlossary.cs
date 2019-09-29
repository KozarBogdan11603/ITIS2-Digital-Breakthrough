﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurTaxationGlossary : MonoBehaviour
{
    Dictionary<string, string> glossary = new Dictionary<string, string>
    {
        {"ENVD IP",  "ЕНВД ИП"},
        {"ENVD Organization", "ЕНВД Юр. лицо" },
        {"ESHN IP", "ЕСХН ИП" },
        {"ESHN Organization", "ЕСХН Юр. лицо" },
        {"OSN IP", "Индивидуальный предприниматель на общей системе налогообложения должен платить: \n ● НДФЛ (Налог на доходы физических лиц); \n ● Страховые взносы на обязательное пенсионное и медицинское страхование; \n ● НДС(Налог на добавленную стоимость). \n ● НДФЛ за сотрудников; \n ● Страховые взносы за сотрудников; \n ● Транспортный налог(за личный транспорт); \n ● Налог на имущество(за квартиру, дом, дачу); \n ● Земельный налог(за земельный участок);" },
        {"OSN Organization", "Организация на общей системе налогообложения должна платить: ● Налог на прибыль организации; ● Налог на добавленную стоимость; ● НДФЛ за своих сотрудников(при их наличии); ● Страховые взносы за сотрудников(при их наличии); ● Налог на имущество организаций; ● Транспортный налог; ● Земельный налог." },
        { "USN IP", "УСН ИП" },
        {"USN Organization", "УСН Юр. лицо" },
        {"PSN", "При применении ПСН, индивидуальные предприниматели уплачивают: \n • Стоимость патента(ПСН); \n • НДФЛ за сотрудников; \n • Страховые взносы «за себя»; \n • Страховые взносы за сотрудников; \n • Транспортный налог(за личный транспорт); \n • Налог на имущество(за квартиру, дом, дачу); \n • Земельный налог(за земельный участок);" },
    };

    private void Awake()
    {
        Taxation curTaxation = Controller.Instance.GetCurTaxation();
        TextMeshProUGUI text = GetComponent<TextMeshProUGUI>();
        text.SetText(glossary[curTaxation.name]);
    }
}

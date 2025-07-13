# Biogenom Nutrition API

## Описание
Тестовое задание для Biogenom.

## Требования
- .NET 9 SDK
- PostgreSQL

## Database Schema

База данных использует PostgreSQL и состоит из одной таблицы `NutritionAssessments`, которая хранит результаты оценки качества питания.

---

#### Таблица `NutritionAssessments`
| Поле            | Тип             | Описание                  |
|------------------|------------------|---------------------------|
| `Id`             | SERIAL           | Уникальный идентификатор оценки |
| `DateCompleted`  | TIMESTAMP        | Дата завершения оценки    |
| `VitaminC`       | DECIMAL(10,2)   | Уровень витамина C (мг)  |
| `VitaminD`       | DECIMAL(10,2)   | Уровень витамина D (мкг) |
| `Water`          | DECIMAL(10,2)   | Употребление воды (г)     |
| `Zinc`           | DECIMAL(10,2)   | Уровень цинка (мг)       |
| `Energy`         | DECIMAL(10,2)   | Энергетическая ценность (ккал) |
| `Recommendations`| TEXT             | Персонализированные рекомендации |

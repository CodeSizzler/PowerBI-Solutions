# Legal Analytics Dashboard – Power BI Implementation

This repository contains a scalable legal intelligence dashboard built in **Power BI**, designed to simulate and demonstrate internal analytics for a modern legal services firm.

A synthetic dataset containing **1 million+ records across 50+ fields** was generated to replicate realistic law firm operations — including departments, attorneys, clients, case metadata, outcomes, timestamps, and financial data.

---

## Technical Overview

### Data Simulation
- Generated using a custom Python script
- Includes 1,000,000 rows and 51 structured columns
- Simulates real legal firm activity across:
  - Client types (e.g., High Value, Pro Bono)
  - Legal departments and attorneys
  - Practice areas and outcomes
  - Case timelines and settlement amounts
  - Derived fields like satisfaction score and complexity index

### Data Model & DAX
- Star schema built in Power BI using fact and dimension tables
- All KPIs implemented as **explicit measures** using DAX
- Measures built and managed using **Tabular Editor**
- Calculations include:
  - Total Cases
  - Win Rate
  - Avg. Case Duration (Days)
  - Outcome Distribution by Department
  - Top Practice Areas by Case Volume
  - Weighted performance scoring (based on custom logic)

### Performance Optimization
- Model optimized to handle large volumes (1M+ rows) without lag
- No bi-directional relationships; clean one-to-many joins
- Efficient use of `CALCULATE`, `SUMMARIZECOLUMNS`, and conditional logic
- Responsive visuals with minimal overhead

### Visual Layer (Power BI)
- Entire dashboard built using **default visuals only** — no external dependencies
- Structured layout with consistent formatting, spacing, and interaction
- Measures integrated with slicers and filters for drilldown analysis
- All visuals styled manually for clarity and consistency

## Key Features

- Operational KPIs with custom DAX logic
- Client segmentation and volume tracking
- Departmental outcome reporting
- Trend analysis by filing date and performance
- High-resolution visuals for reporting and presentation use
- Ready to adapt to real production datasets

## Contents

| File | Description |
|------|-------------|
| `generate_data.py` | Python script to simulate legal firm dataset |
| `sample_legal_firm_data_1M.csv.zip` | Generated 1M-row dataset |
| `.pbix` | Power BI dashboard file (not included in repo by default) |
| `README.md` | This documentation file |

## Intended Use

This dashboard can be adapted for:

- Legal operations & compliance teams
- Internal firm analytics
- Executive reporting for legal services
- Stakeholder reviews and performance tracking

## Stack

- Power BI Desktop
- Python 3.x
- DAX (Data Analysis Expressions)
- Tabular Editor


## Notes

This project was developed as a demonstration of how large-scale legal datasets can be transformed into actionable internal analytics. The data used here is entirely synthetic and does not represent any real clients or cases.


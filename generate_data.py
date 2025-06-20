import pandas as pd
import numpy as np
from faker import Faker
import random
from tqdm import tqdm

# Settings
fake = Faker()
np.random.seed(42)
Faker.seed(42)

# Parameters
num_rows = 1_000_000
output_file = "sample_legal_firm_data_1M.csv.zip"

# Pre-generate static values
practice_areas = ['Corporate', 'Litigation', 'Intellectual Property', 'Employment', 'Real Estate', 'Family Law', 'Tax', 'Environmental', 'Bankruptcy', 'Healthcare']
case_outcomes = ['Won', 'Lost', 'Settled', 'Dismissed', 'Pending']
court_types = ['District', 'Appeals', 'Supreme', 'Local', 'Federal']
departments = ['Civil', 'Criminal', 'Corporate', 'Compliance', 'IP', 'Labor']
judges = [fake.name() for _ in range(100)]
attorneys = [fake.name() for _ in range(500)]

# Storage containers
data = []

print("Generating 1 million legal firm records...\n")

for i in tqdm(range(num_rows)):
    row = {
        'Case_ID': f'CASE{1000000 + i}',
        'Client_Name': fake.company(),
        'Case_Title': fake.sentence(nb_words=6),
        'Attorney': random.choice(attorneys),
        'Judge': random.choice(judges),
        'Practice_Area': random.choice(practice_areas),
        'Court_Type': random.choice(court_types),
        'Department': random.choice(departments),
        'Outcome': random.choice(case_outcomes),
        'Filed_Date': fake.date_between(start_date='-3y', end_date='-1y'),
        'Closed_Date': fake.date_between(start_date='-1y', end_date='today'),
        'Billable_Hours': random.randint(5, 500),
        'Hourly_Rate': random.choice([150, 200, 250, 300, 350]),
        'Settlement_Amount': random.randint(0, 100000),
        'Is_High_Value_Client': random.choice([True, False]),
        'Is_Pro_Bono': random.choice([True, False]),
        'Legal_Complexity_Score': round(random.uniform(1, 10), 2),
        'Client_Satisfaction_Score': round(random.uniform(1, 5), 2),
        'Case_Notes': fake.text(max_nb_chars=100),
    }
    
    # Add 32 extra metadata columns
    for j in range(1, 33):
        row[f'Custom_Field_{j}'] = random.choice(['Low', 'Medium', 'High', 'Critical'])

    data.append(row)

# Build DataFrame
df = pd.DataFrame(data)

# Save
print("\nSaving to CSV...")
df.to_csv(output_file, index=False, compression='zip')
print(f"Done! File saved as: {output_file}")
